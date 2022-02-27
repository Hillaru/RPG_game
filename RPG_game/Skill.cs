using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static RPG_game.Constants;

namespace RPG_game
{
    public enum Skill_tag : int
    {
        cost = 0,
        cd,

        physical,
        magical,
        buff,
        debuff,
        heal,

        aoe,
        st,
        self,
        all,
        random,
        near
    }

    public class Skill
    {
        public int Skill_id;
        public string Name;
        public ArrayList Parameters;

        public Skill(int id, string name, ArrayList parameters)
        {
            Name = name;
            Parameters = parameters;
            Skill_id = id;
        }
    }

    public class Skills_db
    {
        public Skill[] Skills_list = new Skill[Skills_count];
        String _Name;
        ArrayList _Parameters;

        public Skills_db()
        {
            _Name = "Легкая атака";
            _Parameters = new ArrayList() 
                {
                    Skill_tag.cost, 2, Skill_tag.cd, 0,
                    Skill_tag.physical, Skill_tag.st, 
                        Stat.physical_strength, 0.5 
                };
            Skills_list[(int)Skills.light_atk] = new Skill((int)Skills.light_atk, _Name, _Parameters);

            _Name = "Обычная атака";
            _Parameters = new ArrayList()
                {
                    Skill_tag.cost, 3, Skill_tag.cd, 0,
                    Skill_tag.physical, Skill_tag.st,
                        Stat.physical_strength, 0.8
                };
            Skills_list[(int)Skills.medium_atk] = new Skill((int)Skills.medium_atk, _Name, _Parameters);

            _Name = "Тяжелая атака";
            _Parameters = new ArrayList()
                {
                    Skill_tag.cost, 4, Skill_tag.cd, 0,
                    Skill_tag.physical, Skill_tag.st,
                        Stat.physical_strength, 1.3
                };
            Skills_list[(int)Skills.heavy_atk] = new Skill((int)Skills.heavy_atk, _Name, _Parameters);

            _Name = "Сверхтяжелая атака";
            _Parameters = new ArrayList()
                {
                    Skill_tag.cost, 5, Skill_tag.cd, 0,
                    Skill_tag.physical, Skill_tag.st,
                        Stat.physical_strength, 1.8
                };
            Skills_list[(int)Skills.super_heavy_atk] = new Skill((int)Skills.super_heavy_atk, _Name, _Parameters);
        }
    }
}
