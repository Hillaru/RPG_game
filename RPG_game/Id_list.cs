using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    public class Stat_gain
    {
        public Stat Main_stat;
        public Stat[] Gain_stats;
        public int[] multiplier;

        public Stat_gain(Stat _main, Stat[] _stats, int[] _mult)
        {
            Main_stat = _main;
            Gain_stats = _stats;
            multiplier = _mult;
        }
    }

    public class Constants
    {
        public static int Stats_list_size = 50;
        public static int Enemy_list_size = 200;
        public static int Player_list_size = 60;
        public static int Max_player_squad_size = 3;
        public static int Body_parts_count = 3;
        public static int Skills_count = 150;

        public static List<Stat_gain>Stats_gain_per_showable = new List<Stat_gain>
        {
            new Stat_gain(Stat.strength, new Stat[]{Stat.hp, Stat.stamina, Stat.physical_strength}, new int[]{1, 1, 3}),
            new Stat_gain(Stat.vitality, new Stat[]{Stat.hp, Stat.defence, Stat.resistance}, new int[]{2, 3, 3}),
            new Stat_gain(Stat.magic, new Stat[]{Stat.magical_strength, Stat.mana}, new int[]{3, 1}),
            new Stat_gain(Stat.agility, new Stat[]{Stat.accuracy, Stat.evasion, Stat.speed}, new int[]{2, 2, 2}),
            new Stat_gain(Stat.spirit, new Stat[]{Stat.hp, Stat.stamina, Stat.mana, Stat.initiative}, new int[]{1, 3, 3, 2}),
        };
    }

    public static class Converter
    {
        public static string Stat_to_string(Stat stat)
        {
            switch (stat)
            {
                case Stat.hp:
                    return "Здоровье";
                case Stat.physical_strength:
                    return "Сила";
                case Stat.stamina:
                    return "Выносливость";
                case Stat.mana:
                    return "Мана";
                case Stat.initiative:
                    return "Инициатива";
                case Stat.speed:
                    return "Скорость";
                case Stat.lvl:
                    return "Уровень";
                case Stat.exp:
                    return "Опыт";
                case Stat.defence:
                    return "Защита";
                case Stat.magical_strength:
                    return "Магическая сила";
                case Stat.accuracy:
                    return "Точность";
                case Stat.evasion:
                    return "Уворот";
                case Stat.resistance:
                    return "Сопротивление магии";

                case Stat.strength:
                    return "Сила";
                case Stat.magic:
                    return "Магия";
                case Stat.vitality:
                    return "Стойкость";
                case Stat.agility:
                    return "Ловкость";
                case Stat.spirit:
                    return "Дух";
                default:
                    return "-";
            }
        }

        public static Stat String_to_stat(string stat)
        {
            switch (stat)
            {
                case "Здоровье":                
                    return Stat.hp;
                case "Физическая сила":
                    return Stat.physical_strength;
                case "Выносливость":
                    return Stat.stamina;
                case "Мана":
                    return Stat.mana;
                case "Инициатива":
                    return Stat.initiative;
                case "Скорость":
                    return Stat.speed;
                case "Уровень":
                    return Stat.lvl;
                case "Опыт":
                    return Stat.exp;
                case "Защита":
                    return Stat.defence;
                case "Магическая сила":
                    return Stat.magical_strength;
                case "Точность":
                    return Stat.accuracy;
                case "Уворот":
                    return Stat.evasion;
                case "Сопротивление магии":
                    return Stat.resistance;

                case "Сила":
                    return Stat.strength;
                case "Магия":
                    return Stat.magic;
                case "Стойкость":
                    return Stat.vitality;
                case "Ловкость":
                    return Stat.agility;
                case "Дух":
                    return Stat.spirit;
                default:
                    throw new Exception("wrong stat");
            }
        }
    }

    public enum Skill_interface_type : int
    {
        Select_enemy,
        Select_player,
        Select_both,
        Select_none
    }

    public enum Skill_tag : int
    {
        resource = -100000,
        cost,
        cd,

        physical,
        magical,
        buff,
        debuff,
        heal,

        self,
        enemy,
        friend,

        st,
        all,
        random
    }
    public enum Battle_status : int
    {
        in_process,
        player_win,
        enemies_win
    }

    public enum Log_type : int
    {
        battle_start, //1
        turn_order, //1
        turn, //1
        attack, //4
        end_of_raund, //1
        raund_number, //1
        end_of_battle, //2 
        death //2
    }

    public enum Body_part : int
    {
        head = 0,
        body = 1,
        legs = 2
    }

    public enum Skills : int
    {
        //обычные атаки оружием
        light_atk = 0,
        medium_atk = 1,
        heavy_atk = 2,
        super_heavy_atk = 3

        //физические скиллы

    }

    public enum Stat : int
    {
        lvl = 1,
        exp = 2,     

        hp = 4,
        stamina = 5,
        mana = 6,
        defence = 7,
        physical_strength = 8,
        initiative = 9,
        speed = 10,
        accuracy = 11,
        evasion = 12,
        resistance = 13,
        magical_strength = 14,

        exp_gain = 30,
        stat_points = 31,
        action_points = 32,

        //showed stats
        strength = 40,  
        vitality = 41,
        magic = 42,
        agility = 43,
        spirit = 44
    }

    public enum Loot : int
    {
        
    }

    public enum Enemies : int
    {
        small_slime = 0,
        weak_skeleton = 1,
        rotting_zombie = 2,
        armored_skeleton = 3
    }

    public enum PlayableCharacters : int 
    {
        hero = 0,
        super_hero = 50
    }
}
