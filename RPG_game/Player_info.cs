using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    public class Player_info
    { 
        public int[] Stats;

        public Player_info()
        {
            Stats = new int[Constants.Stats_list_size];
            Stats[(int)Stat.hp] = 15;
            Stats[(int)Stat.stamina] = 20;
            Stats[(int)Stat.exp] = 0;
            Stats[(int)Stat.lvl] = 1;
            Stats[(int)Stat.defence] = 2;
            Stats[(int)Stat.strength] = 10;
        }


        //реализовать возможность запуска с сохранением Db_stats(...)
        //реализовать возможность загрузки сохранения Load_save(...)
    }
}
