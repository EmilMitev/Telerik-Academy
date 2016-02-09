namespace SchoolClasses
{
    using System;

    internal abstract class People
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
