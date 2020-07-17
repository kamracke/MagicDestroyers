using System;

namespace MagicDestroyers.Equipment.Armor.Leather
{
    public class LightLeatherVest
    {
        private const int DEFAULT_ARMOR_POINTS = 10;

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
                {
                    this.armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor Points value should be a positive number");
                }
            }
        }

        public LightLeatherVest()
            : this(DEFAULT_ARMOR_POINTS)
        {

        }

        public LightLeatherVest(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
