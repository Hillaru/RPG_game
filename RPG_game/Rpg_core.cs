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
        Players_db P_db = new Players_db();
        Player[] Player_squad = new Player[Constants.Max_player_squad_size];

        public void Initialize_player_squad()
        {
            Player_squad[0] = (Player)P_db.Playable_characters_list[(int)PlayableCharacters.hero].Clone();
        }

        public void Start_new_game()
        {
            Initialize_player_squad();
            Game_loop();
        }

        public void Game_loop()
        {
            Battle_controller BC = new Battle_controller();
            Game_loop();
        }
    }
}
