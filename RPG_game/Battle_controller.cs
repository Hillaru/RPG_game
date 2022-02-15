using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPG_game
{
    class Battle_controller
    {
        Player[] Player_squad;
        Enemy[] Enemy_squad;
        List<Unit> Turn_order = new List<Unit>();

        public Battle_controller(Player[] _Player_squad, Enemy[] _Enemy_squad)
        {
            Player[] Player_squad = _Player_squad;
            Enemy[] Enemy_squad = _Enemy_squad;
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
    }
}
