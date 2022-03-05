using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static RPG_game.Constants;

namespace RPG_game
{
    public struct Skill_with_cd
    {
        public int skill_id;
        public int cd;
    }

    public struct Resource_use
    {
        public Stat resource;
        public int amount;
    }

    public struct Stat_scale
    {
        public Stat stat;
        public double scale;
    }

    public struct Skill_component
    {
        public Skill_tag dmg_type;
        public int number_of_targets;
        public Skill_tag target_type;
        public Skill_tag targeting_style;
        public List<Stat_scale> scales;
        public List<Buff> buff_aplication;
        public List<Special_effect> effects; 
    }

    public class Skill
    {
        public int Skill_id;
        public string Name;
        public Skill_interface_type Interface_Type = Skill_interface_type.Select_none;
        public string Description;

        public int Cd;
        public List<Resource_use> resources = new List<Resource_use>();
        public List<Skill_component> components = new List<Skill_component>();

        public Skill(int id, string name, int cd, Skill_interface_type interface_type, string _description)
        {
            Description = _description;
            Name = name;
            Cd = cd;
            Skill_id = id;
            Interface_Type = interface_type;
        }
    }

    public class Skills_db
    {
        public Skill[] Skills_list = new Skill[Skills_count];
        String _Name;
        int _cd;
        String _description;

        public Skills_db()
        {
            _Name = "Легкая атака";
            _description = "Обычная атака. Урон зависит от физической силы.";
            _cd = 0;
            Skills_list[(int)Skills.light_atk] = new Skill((int)Skills.light_atk, _Name, _cd, Skill_interface_type.Select_enemy, _description);
            Skills_list[(int)Skills.light_atk].resources.Add(new Resource_use { resource = Stat.action_points, amount = 2 });
            Skills_list[(int)Skills.light_atk].components.Add(
                new Skill_component 
                { 
                    dmg_type = Skill_tag.physical, 
                    number_of_targets = 1, 
                    target_type = Skill_tag.enemy, 
                    targeting_style = Skill_tag.st, 
                    scales = new List<Stat_scale> { new Stat_scale{ stat = Stat.physical_strength, scale = 0.4 } } 
                });

            _Name = "Обычная атака";
            _description = "Обычная атака. Урон зависит от физической силы.";
            _cd = 0;
            Skills_list[(int)Skills.medium_atk] = new Skill((int)Skills.medium_atk, _Name, _cd, Skill_interface_type.Select_enemy, _description);
            Skills_list[(int)Skills.medium_atk].resources.Add(new Resource_use { resource = Stat.action_points, amount = 3 });
            Skills_list[(int)Skills.medium_atk].components.Add(
                new Skill_component
                {
                    dmg_type = Skill_tag.physical,
                    number_of_targets = 1,
                    target_type = Skill_tag.enemy,
                    targeting_style = Skill_tag.st,
                    scales = new List<Stat_scale> { new Stat_scale { stat = Stat.physical_strength, scale = 0.7 } }
                });

            _Name = "Тяжелая атака";
            _description = "Обычная атака. Урон зависит от физической силы.";
            _cd = 0;
            Skills_list[(int)Skills.heavy_atk] = new Skill((int)Skills.heavy_atk, _Name, _cd, Skill_interface_type.Select_enemy, _description);
            Skills_list[(int)Skills.heavy_atk].resources.Add(new Resource_use { resource = Stat.action_points, amount = 4 });
            Skills_list[(int)Skills.heavy_atk].components.Add(
                new Skill_component
                {
                    dmg_type = Skill_tag.physical,
                    number_of_targets = 1,
                    target_type = Skill_tag.enemy,
                    targeting_style = Skill_tag.st,
                    scales = new List<Stat_scale> { new Stat_scale { stat = Stat.physical_strength, scale = 1.1 } }
                });

            _Name = "Сверхтяжелая атака";
            _description = "Обычная атака. Урон зависит от физической силы.";
            _cd = 0;
            Skills_list[(int)Skills.super_heavy_atk] = new Skill((int)Skills.super_heavy_atk, _Name, _cd, Skill_interface_type.Select_enemy, _description);
            Skills_list[(int)Skills.super_heavy_atk].resources.Add(new Resource_use { resource = Stat.action_points, amount = 5 });
            Skills_list[(int)Skills.super_heavy_atk].components.Add(
                new Skill_component
                {
                    dmg_type = Skill_tag.physical,
                    number_of_targets = 1,
                    target_type = Skill_tag.enemy,
                    targeting_style = Skill_tag.st,
                    scales = new List<Stat_scale> { new Stat_scale { stat = Stat.physical_strength, scale = 1.7 } }
                });
        }
    }
}
