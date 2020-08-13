using System;
using MagicDestroyers.Equipment.Weapon.Blunt;
using MagicDestroyers.Equipment.Armor.Heavy;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {
        private const Faction DEFAULT_FACTION = Enums.Faction.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const string DEFAULT_NAME = "Nick";

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        //private Faction faction;

        //private int abilityPoints;
        //private int healthPoints;
        //private int level;

        //private string name;

        private Chainlink bodyArmor;
        private Hammer weapon;

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

        //public int AbilityPoints
        //{
        //    get
        //    {
        //        return this.abilityPoints;
        //    }
        //    set
        //    {
        //        if (value >= 0 && value <= 10)
        //            this.abilityPoints = value;
        //        throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 10.");

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

        public Chainlink BodyArmor
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

        public Hammer Weapon
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

        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Knight(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Knight(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }

        //Chainlink mithril = new Chainlink();

        //Hammer mulnir = new Hammer();
    }
}
