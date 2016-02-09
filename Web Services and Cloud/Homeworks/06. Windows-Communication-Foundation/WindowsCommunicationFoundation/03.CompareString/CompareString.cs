namespace _03.CompareString
{
    using System.Text.RegularExpressions;

    public class CompareString : ICompareString
    {
        public int Contains(string firstString, string secondString)
        {
            var count = Regex.Matches(secondString, firstString).Count;
            return count;
        }
    }
}
