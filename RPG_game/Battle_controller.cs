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
        List<Player> Player_squad;
        List<Enemy> Enemy_squad;
        List<Unit> Turn_order = new List<Unit>();
        int Cureent_turn = 0, Raund_num = 1;
        List<String> Log = new List<string>();
        List<String> New_log = new List<string>();

        public Battle_controller(List<Player> _Player_squad, List<Enemy> _Enemy_squad)
        {
            Player_squad = _Player_squad;
            Enemy_squad = _Enemy_squad;
        }

        private void Sort_by_speed()
        {
            int i, j;
            Unit x;
            int size = Turn_order.Count();

            for (i = 0; i < size; i++)
            {
                for (j = size - 1; j > i; j--)
                {
                    if (Turn_order[j - 1].Current_stats[(int)Stat.speed] < Turn_order[j].Current_stats[(int)Stat.speed])
                    {
                        x = Turn_order[j - 1];
                        Turn_order[j - 1] = Turn_order[j];
                        Turn_order[j] = x;
                    }
                }
            }
        }

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

        public void Physical_attack(Unit Attacker, Unit Defender, Body_part body_Part)
        {
            double Atk = Attacker.Current_stats[(int)Stat.strength];
            double Def = Defender.Current_stats[(int)Stat.defence];

            Atk -= Def;

            if (Defender.Defended_state[(int)body_Part] == true)
                Def *= 2;

            Atk *= Defender.Body_part_multiplier[(int)body_Part];

            Defender.Current_stats[(int)Stat.hp] -= (int)Math.Round(Atk);
        }

        public void Update_turn_order()
        {
            Turn_order = new List<Unit>();
            foreach (Player p in Player_squad)
                Turn_order.Add(p);
            foreach (Enemy e in Enemy_squad)
                Turn_order.Add(e);
            Sort_by_speed();

        }

        public void Logger(Log_type Type)
        {
            String Log_line;
            switch (Type)
            {
                case Log_type.turn_order:
                    {
                        Log_line = "Текущий порядок ходов: ";
                        for (int i = Cureent_turn; i < Turn_order.Count(); i++)
                            if (i == Cureent_turn - 1)
                                Log_line += Turn_order[i].Name;
                            else
                                Log_line += Turn_order[i].Name + " -> ";
                        break;
                    };

                case Log_type.turn:
                    {
                        Log_line = "Сейчас ходит " + Turn_order[Cureent_turn].Name;
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
        public void Logger(Log_type Type, bool Win)
        {
            if (Type == Log_type.end_of_battle)
                if (Win)
                    New_log.Add("ПОБЕДА");
                else
                    New_log.Add("ПОРАЖЕНИЕ");
        }
        public void Logger(Log_type Type, Unit unit)
        {
            if (Type == Log_type.death)
            {
                New_log.Add($"{unit.Name} погиб");
            }
        }
        public void Logger(Log_type Type, Unit Attacker, Unit Defender, Body_part body_Part, int Dmg)
        {
            String Log_line;
            if (Type == Log_type.attack)
            {
                if (Defender.Defended_state[(int)body_Part] == true)
                    Log_line = $"{Attacker.Name} атакует {Defender.Name} и наносит {Dmg} урона (блок)";
                else
                    Log_line = $"{Attacker.Name} атакует {Defender.Name} и наносит {Dmg} урона";
            }
        }
    }
}
