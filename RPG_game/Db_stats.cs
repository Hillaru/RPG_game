using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    class Db_stats
    {
        private const int Size = 10; 
        public int[] Stats;

        enum Stat : int
        {
            hp = 1,
            stamina = 2,
            exp = 3,
            defence = 4,
            strength = 5
        }

        public Db_stats()
        {
            Stats = new int[Size];
            Stats[(int)Stat.hp] = 15;
            Stats[(int)Stat.stamina] = 20;
            Stats[(int)Stat.exp] = 0;
            Stats[(int)Stat.defence] = 1;
            Stats[(int)Stat.strength] = 5;
        }


        //реализовать возможность запуска с сохранением Db_stats(...)
        //реализовать возможность загрузки сохранения Load_save(...)
    }
}
