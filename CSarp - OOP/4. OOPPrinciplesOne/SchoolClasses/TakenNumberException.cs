namespace SchoolClasses
{
    using System;

    internal class TakenNumberException : ApplicationException
    {
        public TakenNumberException(string msg)
            : base(msg)
        {
        }
    }
}
