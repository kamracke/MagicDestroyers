using System;
using System.Collections.Generic;
using System.Text;

namespace MagicDestroyers.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0)
                    this.manaPoints = value;
                throw new ArgumentOutOfRangeException(string.Empty, "The value must be greater than or equal to 0");

            }
        }
    }
}
