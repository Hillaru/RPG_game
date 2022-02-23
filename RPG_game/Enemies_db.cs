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
        public Enemies Enemy_type;

        public Enemy(string _Name, int[] _Stats, double[] _Body_part_multiplier, Enemies type)
        {
            Name = _Name;
            Enemy_type = type;

            for (int i = 0; i < Constants.Body_parts_count; i++)
                Body_part_multiplier[i] = _Body_part_multiplier[i];

            Max_stats = new int[Constants.Stats_list_size];
            Current_stats = new int[Constants.Stats_list_size];
            for (int i = 0; i < Constants.Stats_list_size; i++)
            {
                Current_stats[i] = _Stats[i];
                Max_stats[i] = _Stats[i];
            }
            Is_playable = false;
        }

        public void Lvl_adjust(int lvl)
        {
            if (lvl == 1)
                return;

            Enemies_db E_db = new Enemies_db();
            Enemy Basic_variant = (Enemy)E_db.Enemies_list[(int)Enemy_type].Clone();
            double Stats_multiplier = 0.08;

            for (int i = 4; i < 30; i++)
            {
                Max_stats[i] = (int)Math.Round(Max_stats[i] + (Basic_variant.Max_stats[i] * Stats_multiplier * lvl));
                Current_stats[i] = Max_stats[i];
            }
        }

        public object Clone()
        {
            return new Enemy(Name, Max_stats, Body_part_multiplier, Enemy_type);
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
            _Stats[(int)Stat.exp_gain] = 5;
            _Stats[(int)Stat.hp] = 10;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.lvl] = 1;
            _Stats[(int)Stat.defence] = 5;
            _Stats[(int)Stat.strength] = 4;
            _Stats[(int)Stat.initiative] = 5;
            _Body_part_multiplier[(int)Body_part.head] = 1;
            _Body_part_multiplier[(int)Body_part.body] = 1;
            _Body_part_multiplier[(int)Body_part.legs] = 1;
            Enemies_list[(int)Enemies.small_slime] = new Enemy("Маленький слайм", _Stats, _Body_part_multiplier, Enemies.small_slime);

            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.exp_gain] = 10;
            _Stats[(int)Stat.hp] = 15;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.lvl] = 1;
            _Stats[(int)Stat.defence] = 6;
            _Stats[(int)Stat.strength] = 6;
            _Stats[(int)Stat.initiative] = 10;
            _Body_part_multiplier[(int)Body_part.head] = 1.3;
            _Body_part_multiplier[(int)Body_part.body] = 1;
            _Body_part_multiplier[(int)Body_part.legs] = 0.8;
            Enemies_list[(int)Enemies.weak_skeleton] = new Enemy("Слабый скелет", _Stats, _Body_part_multiplier, Enemies.weak_skeleton);

            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.exp_gain] = 10;
            _Stats[(int)Stat.hp] = 28;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.lvl] = 1;
            _Stats[(int)Stat.defence] = 3;
            _Stats[(int)Stat.strength] = 5;
            _Stats[(int)Stat.initiative] = 4;
            _Body_part_multiplier[(int)Body_part.head] = 1.6;
            _Body_part_multiplier[(int)Body_part.body] = 1;
            _Body_part_multiplier[(int)Body_part.legs] = 0.5;
            Enemies_list[(int)Enemies.rotting_zombie] = new Enemy("Гниющий зомби", _Stats, _Body_part_multiplier, Enemies.rotting_zombie);

            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.exp_gain] = 15;
            _Stats[(int)Stat.hp] = 18;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.lvl] = 1;
            _Stats[(int)Stat.defence] = 8;
            _Stats[(int)Stat.strength] = 6;
            _Stats[(int)Stat.initiative] = 9;
            _Body_part_multiplier[(int)Body_part.head] = 1.3;
            _Body_part_multiplier[(int)Body_part.body] = 1;
            _Body_part_multiplier[(int)Body_part.legs] = 0.8;
            Enemies_list[(int)Enemies.armored_skeleton] = new Enemy("Бронированный скелет", _Stats, _Body_part_multiplier, Enemies.armored_skeleton);
        }
    }
}
