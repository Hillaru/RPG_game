using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_game.Constants;

namespace RPG_game
{
    public class Player : Unit
    {
        public PlayableCharacters Player_type;

        public Player(string _Name, int[] _Stats, double[] _Body_part_multiplier, PlayableCharacters type, int[] _Skills)
        {
            Name = _Name;
            Player_type = type;
            Skills = new Skill_with_cd[_Skills.Length];
            for (int i = 0; i < _Skills.Length; i++)
            {
                Skills[i].skill_id = _Skills[i];
                Skills[i].cd = 0;
            }

            for (int i = 0; i < Body_parts_count; i++)
                Body_part_multiplier[i] = _Body_part_multiplier[i];

            Max_stats = new int[Stats_list_size];
            Current_stats = new int[Stats_list_size];
            for (int i = 0; i < Stats_list_size; i++)
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
                Max_stats[(int)Stat.exp] = (int)Math.Round(Max_stats[(int)Stat.exp] * 1.35);

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

            Max_stats[(int)Stat.stat_points] += lvl_ups * 3;
            Current_stats[(int)Stat.stat_points] += lvl_ups * 3;
        }      

        public void Active_stats_gain(int[] Stats_to_add, int Left_stat_points)
        {
            for (int showable_index = 40; showable_index < 50; showable_index++)
            {
                if (Stats_to_add[showable_index] == 0)
                    continue;
                
                for (int stat_index = 0; stat_index < Stats_gain_per_showable[showable_index - 40].Gain_stats.Length; stat_index++)
                {
                    int stat_id = (int)Stats_gain_per_showable[showable_index - 40].Gain_stats[stat_index];
                    Max_stats[stat_id] += Stats_to_add[showable_index] * Stats_gain_per_showable[showable_index - 40].multiplier[stat_index];
                    Current_stats[stat_id] = Max_stats[stat_id];
                }
            }
            Current_stats[(int)Stat.stat_points] = Left_stat_points;
        }

        public object Clone()
        {
            int[] _Skills = new int[Skills.Length];
            for (int i = 0; i < _Skills.Length; i++)
                _Skills[i] = Skills[i].skill_id;

            return new Player(Name, Max_stats, Body_part_multiplier, Player_type, _Skills);
        }
    }

    public class Players_db
    {
        public Player[] Playable_characters_list = new Player[Player_list_size];
        int[] _Stats;
        double[] _Body_part_multiplier = new double[Body_parts_count];
        int[] _Skills;

        public Players_db()
        {
            _Stats = new int[Stats_list_size];
            _Stats[(int)Stat.hp] = 15;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.exp] = 15;
            _Stats[(int)Stat.lvl] = 1;
            _Stats[(int)Stat.defence] = 2;
            _Stats[(int)Stat.physical_strength] = 10;
            _Stats[(int)Stat.initiative] = 10;
            _Stats[(int)Stat.speed] = 30;
            _Stats[(int)Stat.accuracy] = 5;
            _Stats[(int)Stat.evasion] = 6;
            _Stats[(int)Stat.resistance] = 2;
            _Stats[(int)Stat.magical_strength] = 10;
            _Body_part_multiplier[(int)Body_part.head] = 1.2;
            _Body_part_multiplier[(int)Body_part.body] = 1;
            _Body_part_multiplier[(int)Body_part.legs] = 0.8;
            _Skills = new int[] { (int)Skills.medium_atk };
            Playable_characters_list[(int)PlayableCharacters.hero] = new Player("Герой", _Stats, _Body_part_multiplier, PlayableCharacters.hero, _Skills);

            _Stats = new int[Stats_list_size];
            _Stats[(int)Stat.hp] = 10000;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.exp] = 10;
            _Stats[(int)Stat.lvl] = 1;
            _Stats[(int)Stat.defence] = 10000;
            _Stats[(int)Stat.physical_strength] = 20;
            _Stats[(int)Stat.initiative] = 10;
            _Stats[(int)Stat.speed] = 30;
            _Stats[(int)Stat.accuracy] = 5;
            _Stats[(int)Stat.evasion] = 5;
            _Stats[(int)Stat.resistance] = 2;
            _Stats[(int)Stat.magical_strength] = 10;
            _Body_part_multiplier[(int)Body_part.head] = 1;
            _Body_part_multiplier[(int)Body_part.body] = 1;
            _Body_part_multiplier[(int)Body_part.legs] = 1;
            _Skills = new int[] { (int)Skills.medium_atk };
            Playable_characters_list[(int)PlayableCharacters.super_hero] = new Player("Босс качалки", _Stats, _Body_part_multiplier, PlayableCharacters.super_hero, _Skills);
        }
    }
}
