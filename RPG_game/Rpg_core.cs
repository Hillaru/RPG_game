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
        Battle_controller BC;
        List<Player> Player_squad = new List<Player>(Constants.Max_player_squad_size);

        Random Rand = new Random();

        public void Initialize_player_squad()
        {
            Players_db P_db = new Players_db();
            Player_squad[0] = (Player)P_db.Playable_characters_list[(int)PlayableCharacters.hero].Clone();
        }

        public void Start_new_game()
        {
            Initialize_player_squad();
            Game_loop();
        }

        private List<Enemy> Generate_enemy_squad()
        {
            Enemies_db E_db = new Enemies_db();
            int Average_lvl = Player_squad[0].Current_stats[(int)Stat.lvl];
            int Max_squad_size = 1 + Average_lvl / 10;

            List<Enemy> Enemy_squad = new List<Enemy>(Rand.Next(1, Max_squad_size));
            for (int i = 0; i < Enemy_squad.Count; i++)
            {
                Enemy_squad[i] = (Enemy)E_db.Enemies_list[Rand.Next(1, 4)].Clone();
                Enemy_squad[i].Current_stats[(int)Stat.lvl] = Rand.Next(Average_lvl - 2, Average_lvl + 1);
                if (Enemy_squad[i].Current_stats[(int)Stat.lvl] <= 0)
                    Enemy_squad[i].Current_stats[(int)Stat.lvl] = 1;
            }

            return (Enemy_squad);
        }

        public void Game_loop()
        {
            
            BC = new Battle_controller(Player_squad, Generate_enemy_squad());

            Game_loop();
        }
    }
}
