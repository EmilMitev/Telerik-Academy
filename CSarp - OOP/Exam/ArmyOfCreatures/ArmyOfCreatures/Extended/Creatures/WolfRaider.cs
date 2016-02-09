namespace ArmyOfCreatures.Extended.Creatures
{
    using System;

    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;

    public class WolfRaider : Creature
    {
        private const int AttackPoints = 8;
        private const int DefensePoints = 5;
        private const int HealtPoints = 10;
        private const decimal DamagePoints = 3.5m;

        public WolfRaider()
            : base(AttackPoints, DefensePoints, HealtPoints, DamagePoints)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }
    }
}