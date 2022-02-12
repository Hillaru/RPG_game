using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    public class Constants
    {
        public static int Stats_list_size = 10;
        public static int Enemy_list_size = 10;
    }

    public enum Stat : int
    {
        exp = 1,
        lvl = 2,
        hp = 4,
        stamina = 5,
        mana = 6,
        defence = 7,
        strength = 8
    }

    public enum Loot : int
    {
        
    }

    public enum Enemies : int
    {
        small_slime = 1,
        weak_skeleton = 2,
        rotting_zombie = 3,
        armored_skeleton = 4
    }
}
