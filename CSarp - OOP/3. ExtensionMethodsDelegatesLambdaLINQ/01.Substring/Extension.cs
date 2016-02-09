namespace _01.Substring
{
    using System.Text;

    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            string result = builder.ToString().Substring(index, length);
            StringBuilder sbResult = new StringBuilder(result);
            return sbResult;
        }

        public static StringBuilder Substring(this StringBuilder builder, int index)
        {
            string result = builder.ToString().Substring(index);
            StringBuilder sbResult = new StringBuilder(result);

            return sbResult;
        }
    }
}