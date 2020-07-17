using System;

namespace MagicDestroyers.Equipment.Armor.Heavy
{
    public class Chainlink
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
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor Points should be a positive number");
                }
            }
        }

        public Chainlink()
            : this(DEFAULT_ARMOR_POINTS)
        {

        }

        public Chainlink(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
