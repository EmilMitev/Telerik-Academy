namespace RangeExceptions
{
    using System;

    internal class InvalidRangeException<T> : ApplicationException
        where T : IComparable<T>
    {
        public InvalidRangeException(string msg, T start, T end)
            : base(string.Format("{0}\nParameter should be in range [{1} - {2}]", msg, start, end))
        {
        }
    }
}
