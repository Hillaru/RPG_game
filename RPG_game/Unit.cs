using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    class Unit
    {
        public string Name;
        public int[] Max_stats;
        public int[] Current_stats;

        public Unit(string _Name, int[] _Stats)
        {
            Name = _Name;
            Max_stats = new int[Constants.Stats_list_size];
            Current_stats = new int[Constants.Stats_list_size];
            for (int i = 0; i < Constants.Stats_list_size; i++)
            {
                Current_stats[i] = _Stats[i];
                Max_stats[i] = _Stats[i];
            }
        }

        public object Clone()
        {
            return new Enemy(Name, Max_stats);
        }
    }
}
