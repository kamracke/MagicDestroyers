using System;

namespace MagicDestroyers.Equipment.Weapon.Blunt
{
    public class Hammer : Blunt
    {
        public const int DEFAULT_DAMAGE_POINTS = 10;

        
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
