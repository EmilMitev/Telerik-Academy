namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;

    class DoubleAttackWhenAttacking: Specialty
    {
        private int rounds;

        public DoubleAttackWhenAttacking(int rounds)
        {
            if (rounds <= 0)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0");
            }

            this.Rounds = rounds;
        }

        public override void ApplyWhenAttacking(ICreaturesInBattle attackeWithSpecialty, ICreaturesInBattle defender)
        {
            if (attackeWithSpecialty == null)
            {
                throw new ArgumentNullException("defenderWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("attacker");
            }

            if (this.rounds <= 0)
            {
                return;
            }

            attackeWithSpecialty.CurrentAttack *= 2;
            this.rounds--;
        }

        public int Rounds
        {
            get
            {
                return this.rounds;
            }
            set
            {
                this.rounds = value;
            }
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
    }
}
