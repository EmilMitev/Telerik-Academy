namespace SchoolClasses
{
    using System.Collections.Generic;

    internal class Teacher : People
    {
        private List<Discipline> disciplines;

        private string comment;

        public Teacher(string name, List<Discipline> disc, string comm = null)
                    : base(name)
        {
            this.Disciplines = disc;
            this.Comment = comm;
        }

        public string Comment { get; set; }

        public List<Discipline> Disciplines { get; set; }
    }
}
