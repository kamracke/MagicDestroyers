using System;

namespace MagicDestroyers.Equipment.Weapon.Sharp
{
    public class Axe : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        
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
