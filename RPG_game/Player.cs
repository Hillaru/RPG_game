using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    public class Player : Unit
    {
        public PlayableCharacters Player_type;

        public Player(string _Name, int[] _Stats, double[] _Body_part_multiplier, PlayableCharacters type)
        {
            Name = _Name;
            Player_type = type;

            for (int i = 0; i < Constants.Body_parts_count; i++)
                Body_part_multiplier[i] = _Body_part_multiplier[i];

            Max_stats = new int[Constants.Stats_list_size];
            Current_stats = new int[Constants.Stats_list_size];
            for (int i = 0; i < Constants.Stats_list_size; i++)
            {
                Current_stats[i] = _Stats[i];
                Max_stats[i] = _Stats[i];
            }
            Current_stats[(int)Stat.exp] = 0;
            Is_playable = true;
        }

        private int Gain_exp(int exp)
        {
            int lvl_ups = 0;

            if (Current_stats[(int)Stat.exp] + exp >= Max_stats[(int)Stat.exp])
            {
                lvl_ups++;
                Current_stats[(int)Stat.lvl]++;
                exp -= (Max_stats[(int)Stat.exp] - Current_stats[(int)Stat.exp]);

                Current_stats[(int)Stat.exp] = 0;
                Max_stats[(int)Stat.exp] = (int)Math.Round(Max_stats[(int)Stat.exp] * 1.2);

                lvl_ups += Gain_exp(exp);
            }
            else
            {
                Current_stats[(int)Stat.exp] += exp;
                return 0;
            }

            return lvl_ups;
        }

        public void Lvl_up(int exp)
        {
            int lvl_ups = Gain_exp(exp);

            if (lvl_ups == 0)
                return;

            Max_stats[(int)Stat.lvl] += lvl_ups;
            Current_stats[(int)Stat.lvl] = Max_stats[(int)Stat.lvl];

            Passive_stats_gain(lvl_ups);
            Max_stats[(int)Stat.stat_points] += lvl_ups * 4;
            Current_stats[(int)Stat.stat_points] += lvl_ups * 4;
        }

        private void Passive_stats_gain(int lvl)
        {
            Players_db P_db = new Players_db();
            Player Basic_variant = (Player)P_db.Playable_characters_list[(int)Player_type].Clone();
            double Stats_multiplier = 0.05;

            for (int i = 4; i < 30; i++)
            {
                int Stat_gain = (int)Math.Round(Basic_variant.Max_stats[i] * Stats_multiplier * lvl);
                
                Max_stats[i] += Stat_gain;
                Current_stats[i] = Max_stats[i];
            }
        }

        public void Active_stats_gain(int[] Stats_to_add, int Left_stat_points)
        {
            for (int i = 0; i < Constants.Stats_list_size; i++)
                if (Stats_to_add[i] != 0)
                {
                    Max_stats[i] += Stats_to_add[i];
                    Current_stats[i] = Max_stats[i];
                }
            Current_stats[(int)Stat.stat_points] = Left_stat_points;
        }

        public object Clone()
        {
            return new Player(Name, Max_stats, Body_part_multiplier, Player_type);
        }
    }

    public class Players_db
    {
        public Player[] Playable_characters_list = new Player[Constants.Player_list_size];
        int[] _Stats;
        double[] _Body_part_multiplier = new double[Constants.Body_parts_count];

        public Players_db()
        {
            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.hp] = 15;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.exp] = 15;
            _Stats[(int)Stat.lvl] = 1;
            _Stats[(int)Stat.defence] = 2;
            _Stats[(int)Stat.strength] = 10;
            _Stats[(int)Stat.initiative] = 10;
            _Body_part_multiplier[(int)Body_part.head] = 1.2;
            _Body_part_multiplier[(int)Body_part.body] = 1;
            _Body_part_multiplier[(int)Body_part.legs] = 0.8;
            Playable_characters_list[(int)PlayableCharacters.hero] = new Player("Герой", _Stats, _Body_part_multiplier, PlayableCharacters.hero);

            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.hp] = 10000;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.exp] = 10;
            _Stats[(int)Stat.lvl] = 1;
            _Stats[(int)Stat.defence] = 10000;
            _Stats[(int)Stat.strength] = 20;
            _Stats[(int)Stat.initiative] = 10;
            _Body_part_multiplier[(int)Body_part.head] = 1;
            _Body_part_multiplier[(int)Body_part.body] = 1;
            _Body_part_multiplier[(int)Body_part.legs] = 1;
            Playable_characters_list[(int)PlayableCharacters.super_hero] = new Player("Босс качалки", _Stats, _Body_part_multiplier, PlayableCharacters.super_hero);
        }
    }
}
