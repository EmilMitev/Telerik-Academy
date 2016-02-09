namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;
    
    public class AncientBehemoth : Creature
    {
        private const int AttackPoints = 19;
        private const int DefensePoints = 19;
        private const int HealtPoints = 300;
        private const decimal DamagePoints = 40;
        private const int ReducePercentage = 80;
        private const int DoubleDefenceRounds = 5;

        public AncientBehemoth()
            : base(AttackPoints, DefensePoints, HealtPoints, DamagePoints)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(ReducePercentage));
            this.AddSpecialty(new DoubleDefenseWhenDefending(DoubleDefenceRounds));
        }
    }
}