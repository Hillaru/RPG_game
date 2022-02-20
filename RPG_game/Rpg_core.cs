using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPG_game
{
    class Rpg_core
    {
        public Battle_controller BC;
        List<Player> Player_squad = new List<Player>();

        Random Rand = new Random((int)DateTime.Now.Ticks);

        public void Initialize_player_squad()
        {
            Players_db P_db = new Players_db();
            Player_squad.Clear();
            Player_squad.Add((Player)P_db.Playable_characters_list[(int)PlayableCharacters.hero].Clone());
            //Player_squad.Add((Player)P_db.Playable_characters_list[(int)PlayableCharacters.super_hero].Clone());
        }

        public void Start_new_game()
        {
            Initialize_player_squad();
            Start_battle();
        }

        private List<Enemy> Generate_enemy_squad()
        {
            Enemies_db E_db = new Enemies_db();
            int Average_lvl = Player_squad[0].Current_stats[(int)Stat.lvl];
            int Max_squad_size = 1 + Average_lvl / 10;
            int Actual_squad_size = Rand.Next(1, Max_squad_size);
            int enemy_id = 0;
            Enemy New_enemy;

            List<Enemy> Enemy_squad = new List<Enemy>();
            for (int i = 0; i < Actual_squad_size; i++)
            {
                enemy_id = Rand.Next(0, 4);
                New_enemy = (Enemy)E_db.Enemies_list[enemy_id].Clone();
                New_enemy.Current_stats[(int)Stat.lvl] = Rand.Next(Average_lvl - 2, Average_lvl + 1);
                if (New_enemy.Current_stats[(int)Stat.lvl] <= 0)
                    New_enemy.Current_stats[(int)Stat.lvl] = 1;

                Enemy_squad.Add(New_enemy);
            }

            return (Enemy_squad);
        }

        public void Start_battle()
        {
            for (int i = 0; i < Player_squad.Count; i++)
                Player_squad[i].Current_stats[(int)Stat.hp] = Player_squad[i].Max_stats[(int)Stat.hp];
            BC = new Battle_controller(Player_squad, Generate_enemy_squad());
        }
    }
}
