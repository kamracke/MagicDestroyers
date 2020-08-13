using System;
using System.Collections.Generic;
using System.Text;

namespace MagicDestroyers.Characters.Melee
{
    public abstract class Melee : Character
    {
        private int abilityPoints;

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0)
                    this.abilityPoints = value;
                throw new ArgumentOutOfRangeException(string.Empty, "The value must be greater than or equal to 0");

            }
        }
    }
}
