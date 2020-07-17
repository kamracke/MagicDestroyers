using System;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer
    {
        public const int DEFAULT_DAMAGE_POINTS = 10;

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
                {
                    this.damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage Points should be a positive number");
                }
            }
        }

        public Hammer()
            : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Hammer(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
