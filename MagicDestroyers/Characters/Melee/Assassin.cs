using System;
using System.Collections.Generic;
using System.Text;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armor;

namespace MagicDestroyers.Characters.Melee
{
    class Assassin
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public Assassin()
        {

        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }

        LightLeatherVest plaidVest = new LightLeatherVest();

        Sword killer = new Sword();
    }
}
