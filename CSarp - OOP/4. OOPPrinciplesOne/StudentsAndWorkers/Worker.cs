namespace StudentsAndWorkers
{
    using System;

    internal class Worker : Human
    {
        private decimal weekSalary;

        private sbyte workHoursPerDay;

        public Worker(string firstname, string lastname, decimal weekSalary, sbyte workHoursPerDay)
            : base(firstname, lastname)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                this.weekSalary = value;
            }
        }

        public sbyte WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} : {2} лв. на час", this.Firstname, this.Lastname, this.WeekSalary / (this.WorkHoursPerDay * 5));
        }
    }
}
