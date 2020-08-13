using System;
using MagicDestroyers.Equipment.Weapon.Sharp;
using MagicDestroyers.Equipment.Armor.Leather;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Melee
    {
        private const Faction DEFAULT_FACTION = Enums.Faction.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const string DEFAULT_NAME = "Sassy";

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Assassin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Assassin(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Assassin(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
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

        public override void Attack()
        {
            this.Raze();
        }

        public override void SpecialAttack()
        {
            this.BleedToDeath();
        }

        public override void Defend()
        {
            this.Survival();
        }

        //LightLeatherVest plaidVest = new LightLeatherVest();

        //Sword killer = new Sword();
    }
}
