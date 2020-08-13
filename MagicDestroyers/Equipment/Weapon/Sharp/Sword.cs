using System;

namespace MagicDestroyers.Equipment.Weapon.Sharp
{
    public class Sword : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

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
