﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftHero
{
    class Enemy
    {
        string name;
        int gold;
        int health;
        Sword sword;
        Armour armour;

        public string Name
        {
            get { return this.name; }
        }

        public int Gold
        {
            get { return this.gold; }
            set { this.gold = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public Armour Armour
        {
            get { return this.armour; }
            set { this.armour = value; }
        }

        public Sword Sword
        {
            get { return this.sword; }
            set { this.sword = value; }
        }

        public Enemy(string name, int gold, int health, int swordDamage, int armourProtection)
        {
            this.name = name;
            this.gold = gold;
            this.health = health;
            this.sword = new Sword(swordDamage);
            this.armour = new Armour(armourProtection);
        }

        public Enemy(string name, int gold, int health)
        {
            this.name = name;
            this.gold = gold;
            this.health = health;
        }

        public Enemy(string name)
        {
            this.name = name;
            this.gold = 10;
            this.health = 100;
        }

        public void Attack(Hero hero)
        {
            hero.GetAttacked(this.sword);
        }

        public void GetAttacked(Sword sword)
        {
            int damage = sword.Damage - this.Armour.Protection;

            if (damage > 0)
            {
                this.health = damage;
            }

        }

    }
}
