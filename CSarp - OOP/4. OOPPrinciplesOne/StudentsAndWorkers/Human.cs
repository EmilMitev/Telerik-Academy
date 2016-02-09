namespace StudentsAndWorkers
{
    public abstract class Human
    {
        protected Human(string firstname, string lastname)
        {
            this.Firstname = firstname;

            this.Lastname = lastname;
        }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}
