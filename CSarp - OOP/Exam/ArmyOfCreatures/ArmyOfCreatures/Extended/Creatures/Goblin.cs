namespace ArmyOfCreatures.Extended.Creatures
{
    using System;
    using ArmyOfCreatures.Logic.Creatures;

    public class Goblin : Creature
    {
        private const int AttackPoints = 4;
        private const int DefensePoints = 2;
        private const int HealtPoints = 5;
        private const decimal DamagePoints = 1.5m;

        public Goblin()
            : base(AttackPoints, DefensePoints, HealtPoints, DamagePoints)
        {
        }
    }
}