using System;
using System.Collections.Generic;
using System.Text;

namespace MagicDestroyers.Equipment.Armor
{
    public class ClothRobe
    {
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
        {

        }
    }
}
