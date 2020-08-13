using MagicDestroyers.Characters.Interfaces;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armor;
using MagicDestroyers.Equipment.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private Faction faction;
        private int healthPoints;
        private int level;
        private string name;
        private Armor bodyArmor;
        private Weapon weapon;


        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }

        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }

        
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                    this.healthPoints = value;
                throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 120.");

            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                    this.level = value;
                throw new ArgumentOutOfRangeException(string.Empty, "The value must be greater than or equal to 0");
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }


        public abstract void Attack();

        public abstract void SpecialAttack();

        public abstract void Defend();
    }
}
