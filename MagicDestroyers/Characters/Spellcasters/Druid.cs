using System;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Weapon.Blunt;
using MagicDestroyers.Equipment.Armor.Leather;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private const Faction DEFAULT_FACTION = Enums.Faction.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const string DEFAULT_NAME = "Dru";

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        //private Faction faction;

        //private int abilityPoints;
        //private int healthPoints;
        //private int level;

        //private string name;

        private LightLeatherVest bodyArmor;
        private Staff weapon;

        //public int AbilityPoints
        //{
        //    get
        //    {
        //        return this.abilityPoints;
        //    }
        //    set
        //    {
        //        if (value >= 0 && value <= 100)
        //            this.abilityPoints = value;
        //        throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 100.");

        //    }
        //}

        //public int HealthPoints
        //{
        //    get
        //    {
        //        return this.healthPoints;
        //    }
        //    set
        //    {
        //        if (value >= 0 && value <= 120)
        //            this.healthPoints = value;
        //        throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 120.");

        //    }
        //}

        //public int Level
        //{
        //    get
        //    {
        //        return this.level;
        //    }
        //    set
        //    {
        //        if (value >= 0)
        //            this.level = value;
        //        throw new ArgumentOutOfRangeException(string.Empty, "The value must be greater than or equal to 0");
        //    }
        //}

        //public string Name
        //{
        //    get
        //    {
        //        return this.name;
        //    }
        //    set
        //    {
        //        this.name = value;
        //    }
        //}
        //public Faction Faction
        //{
        //    get
        //    {
        //        return this.faction;
        //    }
        //    set
        //    {
        //        this.faction = value;
        //    }
        //}

        public LightLeatherVest BodyArmor
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

        public Staff Weapon
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

        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }

        public Druid(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Druid(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = DEFAULT_FACTION;
            this.ManaPoints = DEFAULT_ABILITY_POINTS;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithNature()
        {
            throw new NotImplementedException();
        }

        //LightLeatherVest stripedVest = new LightLeatherVest();

        //Staff magicStick = new Staff();
    }
}
