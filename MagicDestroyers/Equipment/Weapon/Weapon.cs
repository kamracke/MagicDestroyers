using System;
using System.Collections.Generic;
using System.Text;

namespace MagicDestroyers.Equipment.Weapon
{
    public abstract class Weapon
    {
        private int damagePoints;

        public int DamagePoints
        {
            get
            {
                return damagePoints;
            }
            set
            {
                if (value >= 0)
                    this.damagePoints = value;
                throw new ArgumentOutOfRangeException(string.Empty, "Damage Points should be a positive number");
            }
        }

    }
}
