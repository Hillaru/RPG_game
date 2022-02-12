﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    public class Enemy
    {
        public int[] Stats = new int[Constants.Stats_list_size];
        //public List<Loot> Drop_list;
        public string Name;

        public Enemy(string _Name, int[] _Stats)
        {
            Name = _Name;
            Stats = _Stats;
        }
    }

    public class Enemies_db
    {
        public Enemy[] Enemies_list = new Enemy[Constants.Enemy_list_size];
        int[] _Stats;

        Enemies_db()
        {
            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.hp] = 10;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.lvl] = 1;
            _Stats[(int)Stat.defence] = 5;
            _Stats[(int)Stat.strength] = 4;
            Enemies_list[(int)Enemies.small_slime] = new Enemy("Маленький слайм", _Stats);

            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.hp] = 20;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.lvl] = 3;
            _Stats[(int)Stat.defence] = 10;
            _Stats[(int)Stat.strength] = 8;
            Enemies_list[(int)Enemies.weak_skeleton] = new Enemy("Слабый скелет", _Stats);

            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.hp] = 35;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.lvl] = 3;
            _Stats[(int)Stat.defence] = 3;
            _Stats[(int)Stat.strength] = 6;
            Enemies_list[(int)Enemies.rotting_zombie] = new Enemy("Гниющий зомби", _Stats);

            _Stats = new int[Constants.Stats_list_size];
            _Stats[(int)Stat.hp] = 30;
            _Stats[(int)Stat.stamina] = 20;
            _Stats[(int)Stat.lvl] = 5;
            _Stats[(int)Stat.defence] = 20;
            _Stats[(int)Stat.strength] = 13;
            Enemies_list[(int)Enemies.armored_skeleton] = new Enemy("Бронированный скелет", _Stats);
        }
    }
}