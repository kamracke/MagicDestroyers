using System;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword
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
                if (value>= 0)
                {
                    this.damagePoints = value;
                }
            }
        }

        public Sword()
            : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Sword(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
