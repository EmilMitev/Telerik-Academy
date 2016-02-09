namespace ArmyOfCreatures.Extended.Creatures
{
    using System;
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class Griffin : Creature
    {
        private const int AttackPoints = 8;
        private const int DefensePoints = 8;
        private const int HealtPoints = 25;
        private const decimal DamagePoints = 4.5m;

        public Griffin() 
            : base(AttackPoints, DefensePoints, HealtPoints, DamagePoints)
        
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
            this.AddSpecialty(new AddDefenseWhenSkip(3));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}