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
        List<int> Turn_order = new List<int>();

        public Battle_controller(Player[] _Player_squad, Enemy[] _Enemy_squad)
        {
            Player[] Player_squad = _Player_squad;
            Enemy[] Enemy_squad = _Enemy_squad;
        }
        
        private void Update_turn_order()
        {

           
        }
    }
}
