using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    public class Unit 
    {
        public bool Is_playable, Is_dead = false;
        public string Name;
        public int[] Max_stats;
        public int[] Current_stats;
        public bool[] Defended_state = new bool[Constants.Body_parts_count];
        public double[] Body_part_multiplier = new double[Constants.Body_parts_count];
    }
}
