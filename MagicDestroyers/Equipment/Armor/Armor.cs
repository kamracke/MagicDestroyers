using System;
using System.Collections.Generic;
using System.Text;

namespace MagicDestroyers.Equipment.Armor
{
    public abstract class Armor
    {
        private int armorPoints;

        public int ArmorPoints 
        {
            get 
            {
                return armorPoints;
            }
            set
            {
                if (value >= 0)
                    this.armorPoints = value;
                throw new ArgumentOutOfRangeException(string.Empty, "Armor points value should be a positive number.");
            }    
        }
    }
}
