using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    public class Player : ICloneable
    { 
        public int[] Max_stats;
        public int[] Current_stats;
        public string Name;

        public Player(string _Name, int[] _Stats)
        {
            Name = _Name;
            Max_stats = new int[Constants.Stats_list_size];
            Current_stats = new int[Constants.Stats_list_size];
            for (int i = 0; i < Constants.Stats_list_size; i++)
            {
                Current_stats[i] = _Stats[i];
                Max_stats[i] = _Stats[i];
            }
            Current_stats[(int)Stat.exp] = 0;
        }

        public object Clone()
        {
            return new Player(Name, Max_stats);
        }
    }

    public class Players_db
    {
        public Player[] Playable_characters_list = new Player[Constants.Player_list_size];
        int[] _Stats;

        public Players_db()
        {
            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.hp] = 15;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.exp] = 10;
            _Stats[(int)Stat.lvl] = 1;
            _Stats[(int)Stat.defence] = 2;
            _Stats[(int)Stat.strength] = 10;
            _Stats[(int)Stat.speed] = 10;
            Playable_characters_list[(int)PlayableCharacters.hero] = new Player("Герой", _Stats);
        }
    }
}
