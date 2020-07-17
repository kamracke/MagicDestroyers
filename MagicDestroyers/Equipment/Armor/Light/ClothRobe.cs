using System;

namespace MagicDestroyers.Equipment.Armor.Light
{
    public class ClothRobe
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
                if (value > 0)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Value must be greater than 0.");
                }
            }
        }

        public ClothRobe()
            : this(DEFAULT_ARMOR_POINTS)
        {

        }

        public ClothRobe(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
