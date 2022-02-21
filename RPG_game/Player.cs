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

        public int Lvl_up(int exp)
        {
            int lvl_ups = 0;

            if (Current_stats[(int)Stat.exp] + exp >= Max_stats[(int)Stat.exp])
            {
                lvl_ups++;
                Current_stats[(int)Stat.lvl]++;
                exp -= (Max_stats[(int)Stat.exp] - Current_stats[(int)Stat.exp]);

                Current_stats[(int)Stat.exp] = 0;

                lvl_ups += Lvl_up(exp);
            }
            else
                Current_stats[(int)Stat.exp] += exp;

            Max_stats[(int)Stat.lvl] += lvl_ups;
            Current_stats[(int)Stat.lvl] = Max_stats[(int)Stat.lvl];
            Passive_stats_gain(lvl_ups);
            return lvl_ups;
        }

        private void Passive_stats_gain(int lvl)
        {
            Players_db P_db = new Players_db();
            Player Basic_variant = (Player)P_db.Playable_characters_list[(int)Player_type].Clone();
            double Stats_multiplier = 0.1;

            for (int i = 4; i < 30; i++)
            {
                Max_stats[i] = (int)Math.Round(Max_stats[i] + (Basic_variant.Max_stats[i] * Stats_multiplier * lvl));
                Current_stats[i] = Max_stats[i];
            }
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
            _Stats[(int)Stat.exp] = 10;
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
