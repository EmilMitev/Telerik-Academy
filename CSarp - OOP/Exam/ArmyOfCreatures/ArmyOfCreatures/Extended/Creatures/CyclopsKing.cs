namespace ArmyOfCreatures.Extended.Creatures
{
    using System;

    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Extended.Specialties;

    public class CyclopsKing : Creature
    {
        private const int AttackPoints = 17;
        private const int DefensePoints = 13;
        private const int HealtPoints = 70;
        private const int DamagePoints = 18;

        public CyclopsKing()
            : base(AttackPoints, DefensePoints, HealtPoints, DamagePoints)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}