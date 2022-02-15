using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    public class Enemy : Unit 
    {
        //public List<Loot> Drop_list;

        public Enemy(string _Name, int[] _Stats, double[] _Body_part_multiplier)
        {
            Name = _Name;

            for (int i = 0; i < Constants.Body_parts_count; i++)
                Body_part_multiplier[i] = _Body_part_multiplier[i];

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
            return new Enemy(Name, Max_stats, Body_part_multiplier);
        }
    }

    public class Enemies_db
    {
        public Enemy[] Enemies_list = new Enemy[Constants.Enemy_list_size];
        int[] _Stats;
        double[] _Body_part_multiplier = new double[Constants.Body_parts_count];

        public Enemies_db()
        {
            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.hp] = 10;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.lvl] = 1;
            _Stats[(int)Stat.defence] = 5;
            _Stats[(int)Stat.strength] = 4;
            _Stats[(int)Stat.speed] = 5;
            _Body_part_multiplier[(int)Body_part.head] = 1;
            _Body_part_multiplier[(int)Body_part.body] = 1;
            _Body_part_multiplier[(int)Body_part.legs] = 1;
            Enemies_list[(int)Enemies.small_slime] = new Enemy("Маленький слайм", _Stats, _Body_part_multiplier);

            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.hp] = 20;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.lvl] = 3;
            _Stats[(int)Stat.defence] = 10;
            _Stats[(int)Stat.strength] = 8;
            _Stats[(int)Stat.speed] = 12;
            _Body_part_multiplier[(int)Body_part.head] = 1.2;
            _Body_part_multiplier[(int)Body_part.body] = 1;
            _Body_part_multiplier[(int)Body_part.legs] = 0.8;
            Enemies_list[(int)Enemies.weak_skeleton] = new Enemy("Слабый скелет", _Stats, _Body_part_multiplier);

            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.hp] = 35;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.lvl] = 3;
            _Stats[(int)Stat.defence] = 3;
            _Stats[(int)Stat.strength] = 6;
            _Stats[(int)Stat.speed] = 4;
            _Body_part_multiplier[(int)Body_part.head] = 1.8;
            _Body_part_multiplier[(int)Body_part.body] = 1;
            _Body_part_multiplier[(int)Body_part.legs] = 0.5;
            Enemies_list[(int)Enemies.rotting_zombie] = new Enemy("Гниющий зомби", _Stats, _Body_part_multiplier);

            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.hp] = 30;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.lvl] = 5;
            _Stats[(int)Stat.defence] = 20;
            _Stats[(int)Stat.strength] = 13;
            _Stats[(int)Stat.speed] = 14;
            _Body_part_multiplier[(int)Body_part.head] = 1.2;
            _Body_part_multiplier[(int)Body_part.body] = 1;
            _Body_part_multiplier[(int)Body_part.legs] = 0.7;
            Enemies_list[(int)Enemies.armored_skeleton] = new Enemy("Бронированный скелет", _Stats, _Body_part_multiplier);
        }
    }
}
