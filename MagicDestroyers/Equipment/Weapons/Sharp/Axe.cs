using System;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

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
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage Points should be a positive number.");
                }
            }
        }

        public Axe()
            : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Axe(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
