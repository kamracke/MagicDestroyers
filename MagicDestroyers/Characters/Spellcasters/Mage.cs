using System;
using System.Collections.Generic;
using System.Text;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armor;

namespace MagicDestroyers.Characters.Spellcasters
{
    class Mage
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private ClothRobe bodyArmor;
        private Staff weapon;

        public int AbilityPoints 
        { 
            get 
            {
                return abilityPoints;
            } 
            set 
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(string.Empty, "The value must be greater than or equal to 0");
                abilityPoints = value;
            } 
        }

        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 0)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value must be greater than or equal to 0");
                }
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 0)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value must be greater than or equal to 0");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                faction = value;
            }
        }

        public ClothRobe BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                if (value.ArmorPoints > 10)
                    throw new ArgumentOutOfRangeException(string.Empty, "Mage can't wear anything greater than 9");
                bodyArmor = value;
            }
        }

        public Staff Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public Mage()
        {

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
