using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPG_game
{
    class Battle_controller
    {
        public List<Player> Player_squad;
        public List<Enemy> Enemy_squad;
        List<Unit> Turn_order = new List<Unit>();
        int Curent_turn = 0, Raund_num = 1;
        List<String> Old_log = new List<string>();
        List<String> New_log = new List<string>();
        Random rand = new Random((int)DateTime.Now.Ticks);
        public Battle_status Status = Battle_status.in_process;
        private Skills_db skills_db = new Skills_db();

        public Battle_controller(List<Player> _Player_squad, List<Enemy> _Enemy_squad)
        {
            Player_squad = _Player_squad;
            Enemy_squad = _Enemy_squad;
            Logger(Log_type.battle_start);
            Logger(Log_type.raund_number);
            Update_turn_order();

            if (!Turn_order[Curent_turn].Is_playable)
                Turn();
        }

        private void Update_turn_order()
        {
            Turn_order = new List<Unit>();
            foreach (Player p in Player_squad)
                if (!p.Is_dead)
                    Turn_order.Add(p);
            foreach (Enemy e in Enemy_squad)
                if (!e.Is_dead)
                    Turn_order.Add(e);
            Sort_by_initiative();

            Logger(Log_type.turn_order);
            Logger(Log_type.turn);
        }

        private void Sort_by_initiative()
        {
            int i, j;
            Unit x;
            int size = Turn_order.Count();

            for (i = 0; i < size; i++)
            {
                for (j = size - 1; j > i; j--)
                {
                    if (Turn_order[j - 1].Current_stats[(int)Stat.initiative] < Turn_order[j].Current_stats[(int)Stat.initiative])
                    {
                        x = Turn_order[j - 1];
                        Turn_order[j - 1] = Turn_order[j];
                        Turn_order[j] = x;
                    }
                }
            }
        }

        private Battle_status Win_condition()
        {
            int Enemy_count = 0, Players_count = 0;

            foreach (Player p in Player_squad)
                if (!p.Is_dead)
                    Players_count++;
            foreach (Enemy e in Enemy_squad)
                if (!e.Is_dead)
                    Enemy_count++;

            if (Players_count == 0)
            {
                Logger(Log_type.end_of_battle, Battle_status.enemies_win);

                return Battle_status.enemies_win;
            }

            if (Enemy_count == 0)
            {
                Logger(Log_type.end_of_battle, Battle_status.player_win);

                int Total_exp = 0;
                foreach (Enemy e in Enemy_squad)
                    Total_exp += e.Current_stats[(int)Stat.exp_gain];

                foreach (Player p in Player_squad)
                    p.Lvl_up(Total_exp);

                return Battle_status.player_win;
            }

            return Battle_status.in_process;
        }

        public void Reset_action_points()
        {
            for (int i = 0; i < Player_squad.Count; i++)
            {
                Player_squad[i].Max_stats[(int)Stat.action_points] = Player_squad[i].Current_stats[(int)Stat.speed] / 10;
                Player_squad[i].Current_stats[(int)Stat.action_points] = Player_squad[i].Max_stats[(int)Stat.action_points];
            }

            for (int i = 0; i < Enemy_squad.Count; i++)
            {
                Enemy_squad[i].Max_stats[(int)Stat.action_points] = Enemy_squad[i].Current_stats[(int)Stat.speed] / 10;
                Enemy_squad[i].Current_stats[(int)Stat.action_points] = Enemy_squad[i].Max_stats[(int)Stat.action_points];
            }
        }

        public bool Can_cast(Skill skill, int skill_index, Unit caster)
        {
            if (caster.Skills[skill_index].cd != 0)
                return false;

            foreach (Resource_use r in skill.resources)
                if (caster.Current_stats[(int)r.resource] < r.amount)
                    return false;

            return true;
        }

        private void Turn()
        {
            if (Turn_order[Curent_turn].Is_playable)
                return;

            Enemy Attacker = (Enemy)Turn_order[Curent_turn];
            Body_part Defended_part = (Body_part)rand.Next(0, 2);
            Body_part Part_to_attack = (Body_part)rand.Next(0, 2);
            Unit Target = Player_squad[rand.Next(0, Player_squad.Count - 1)];
            List<Skill> Available_skills = new List<Skill>();

            for (int i = 0; i < Attacker.Skills.Length; i++)
            {
                int Skill_id = Attacker.Skills[i].skill_id;
                Skill skill = skills_db.Skills_list[Skill_id];

                if (Can_cast(skill, i, Attacker)) 
                    Available_skills.Add(skill);
            }  

            if (Attacker.Can_block)
                Set_defended_state(Attacker, Defended_part);

            if (Available_skills.Count != 0)
            {

                //Physical_attack(Attacker, Target, Part_to_attack);      

                Status = Win_condition();
                if (Status != Battle_status.in_process)
                    return;
            }

            if (Curent_turn < Turn_order.Count() - 1)
            {
                Curent_turn++;
                Logger(Log_type.turn);
            }
            else
            {
                Logger(Log_type.end_of_raund);
                Raund_num++;
                Curent_turn = 0;
                Logger(Log_type.raund_number);
                Update_turn_order();
            }
            if (!Turn_order[Curent_turn].Is_playable)
                Turn();
        }
        public void Turn(Body_part Defended_part, Body_part Part_to_attack, Unit Target)
        {
            if (!Turn_order[Curent_turn].Is_playable)
                return;

            Player Attacker = (Player)Turn_order[Curent_turn];

            Set_defended_state(Attacker, Defended_part);
            //Physical_attack(Attacker, Target, Part_to_attack);           //Добавить атаку скиллом, добавить использование экшн поинтов

            Status = Win_condition();
            if (Status != Battle_status.in_process)
                return;

            if (Curent_turn < Turn_order.Count() - 1)
            {
                Curent_turn++;
                Logger(Log_type.turn);
            }    
            else
            {
                Logger(Log_type.end_of_raund);
                Raund_num++;
                Curent_turn = 0;
                Logger(Log_type.raund_number);
                Update_turn_order();
            }

            if (!Turn_order[Curent_turn].Is_playable)
                Turn();
        }

        #region Attack_and_defence
        public void Set_defended_state(Unit unit, Body_part body_Part)
        {
            for (int i = 0; i < Constants.Body_parts_count; i++)
            {
                if ((Body_part)i == body_Part)
                    unit.Defended_state[i] = true;
                else
                    unit.Defended_state[i] = false;
            }
        }

        private void Physical_attack(Unit Attacker, Unit Defender, Body_part body_Part, int Atk)    //Переработать для скиллов, также изменить сообщения логгера
        {
            int Def = Defender.Current_stats[(int)Stat.defence];
            int Eva = Defender.Current_stats[(int)Stat.evasion];
            int Acc = Attacker.Current_stats[(int)Stat.accuracy];
            int A_lvl = Attacker.Current_stats[(int)Stat.lvl];
            int D_lvl = Defender.Current_stats[(int)Stat.lvl];
            bool block = false;

            if (Defender.Can_dodge)
            {
                double Dodge_chance = 1 - ((A_lvl * Acc) / (Eva * D_lvl));
                if (Dodge_chance > 0 && rand.NextDouble() < Dodge_chance)
                {
                    Logger(Log_type.attack, Defender, true);
                    return;
                }
            }

            if (Defender.Defended_state[(int)body_Part] && Defender.Can_block)
            {
                Def *= 2;
                block = true;
            }

            Atk = (int)Math.Round(Atk * Defender.Body_part_multiplier[(int)body_Part]);
            Atk -= Def;

            if (Atk < 1) Atk = 1;

            Defender.Current_stats[(int)Stat.hp] -= Atk;
            Logger(Log_type.attack, Defender, false, block, Atk);

            Alive_check(Defender);
        }

        private void Alive_check(Unit unit)
        {
            if (unit.Current_stats[(int)Stat.hp] <= 0 && !unit.Is_dead)
            {
                Turn_order.Remove(unit);
                unit.Is_dead = true;

                Logger(Log_type.death, unit);
            }
        }

        #endregion

        #region Logger
        public List<String> Logger()
        {
            List<String> Logs = new List<string>();
            foreach (String l in New_log)
                Logs.Add(l);
            Old_log.AddRange(New_log);
            New_log.Clear();

            return Logs;
        }
        private void Logger(Log_type Type)
        {
            String Log_line;
            switch (Type)
            {
                case Log_type.turn_order:
                    {
                        Log_line = "Текущий порядок ходов: ";
                        for (int i = Curent_turn; i < Turn_order.Count(); i++)
                            if (i == Turn_order.Count() - 1)
                                Log_line += Turn_order[i].Name;
                            else
                                Log_line += Turn_order[i].Name + " -> ";
                        break;
                    };

                case Log_type.turn:
                    {
                        Log_line = "Сейчас ходит " + Turn_order[Curent_turn].Name;
                        break;
                    }

                case Log_type.battle_start:
                    {
                        Log_line = "Битва началась\n Участники: ";
                        foreach (Player p in Player_squad)
                            Log_line += p.Name + " ";

                        Log_line += "\nVS\n";

                        foreach (Enemy e in Enemy_squad)
                            Log_line += e.Name + " ";
                        break;
                    }

                case Log_type.raund_number:
                    {
                        Log_line = "Раунд№ " + Raund_num;
                        break;
                    }

                case Log_type.end_of_raund:
                    {
                        Log_line = "Конец раунда";
                        break;
                    }

                default: return;
            }

            New_log.Add(Log_line);
        }
        private void Logger(Log_type Type, Battle_status status)
        {
            if (Type == Log_type.end_of_battle)
                switch (status)
                {
                    case Battle_status.player_win:
                        New_log.Add("ПОБЕДА");
                        break;

                    case Battle_status.enemies_win:
                        New_log.Add("ПОРАЖЕНИЕ");
                        break;

                    default: return;
                }
        }
        private void Logger(Log_type Type, Unit unit)
        {
            if (Type == Log_type.death)
            {
                New_log.Add($"{unit.Name} погиб");
            }
        }
        private void Logger(Log_type Type, Unit Defender, bool Dodge = false, bool Block = false, int Dmg = 0)
        {
            String Log_line;
            if (Type == Log_type.attack)
            {
                if (Dodge == true)
                    Log_line = $"- {Defender.Name} уворачивается";
                else
                if (Block == true)
                    Log_line = $"- {Defender.Name} блокирует и получает {Dmg} урона";
                else
                    Log_line = $"- {Defender.Name} получает {Dmg} урона";

                New_log.Add(Log_line);
            }
        } 
        #endregion
    }
}
