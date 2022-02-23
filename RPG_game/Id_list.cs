using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    public class Constants
    {
        public static int Stats_list_size = 50;
        public static int Enemy_list_size = 200;
        public static int Player_list_size = 150;
        public static int Max_player_squad_size = 3;
        public static int Body_parts_count = 3;
    }

    public static class Converter
    {
        public static string Stat_to_string(Stat stat)
        {
            switch (stat)
            {
                case Stat.hp:
                    return "Здоровье";
                case Stat.strength:
                    return "Сила";
                case Stat.stamina:
                    return "Выносливость";
                case Stat.mana:
                    return "Мана";
                case Stat.initiative:
                    return "Инициатива";
                case Stat.speed:
                    return "Скорость";
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
                case "Сила":
                    return Stat.strength;
                case "Выносливость":
                    return Stat.stamina;
                case "Мана":
                    return Stat.mana;
                case "Инициатива":
                    return Stat.initiative;
                case "Скорость":
                    return Stat.speed;
                default:
                    throw new Exception("wrong stat");
            }
        }
    }

    public enum Battle_status : int
    {
        in_process,
        player_win,
        enemies_win
    }

    public enum Log_type : int
    {
        battle_start, //+
        turn_order, //+
        turn, //+
        attack, //++++
        end_of_raund, //+
        raund_number, //+
        end_of_battle, //++ 
        death //++
    }

    public enum Body_part : int
    {
        head = 0,
        body = 1,
        legs = 2
    }

    public enum Stat : int
    {
        exp = 1,
        lvl = 2,
        hp = 4,
        stamina = 5,
        mana = 6,
        defence = 7,
        strength = 8,
        initiative = 9,
        speed = 10,

        exp_gain = 30,
        stat_points = 31
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
        super_hero = 100
    }
}
