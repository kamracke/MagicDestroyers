using System;
using MagicDestroyers.Enums
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Equipment.Armor.Light;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage
    {
        private const Faction DEFAULT_FACTION = Enums.Faction.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const string DEFAULT_NAME = "Midge";

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private Faction faction;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string name;

        private ClothRobe bodyArmor;
        private Staff weapon;

        

        public int AbilityPoints 
        { 
            get 
            {
                return this.abilityPoints;
            } 
            set 
            {
                if (value >= 0 && value <= 100)
                    this.abilityPoints = value;
                throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 100.");
                
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

        public ClothRobe BodyArmor
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

        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Mage(string name, int level, int healthpoints)
        {
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.HealthPoints = healthpoints;
            this.Level = level;
            this.Name = name;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Firewall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }

        //ClothRobe bathRobe = new ClothRobe();

        //Staff trustyStick = new Staff();
    }
}
