namespace BankAccounts
{
    internal class Customer
    {
        private Type type;

        public Customer(Type type)
        {
            this.Type = type;
        }

        public Type Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }
    }
}