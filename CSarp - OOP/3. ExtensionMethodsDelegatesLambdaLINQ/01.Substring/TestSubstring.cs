/* Problem 1.
 * Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new
 * StringBuilder and has the same functionality as Substring in the class String.
 */
namespace _01.Substring
{
    using System;
    using System.Text;

    internal class TestSubstring
    {
        private static void Main()
        {
            Console.Write("Enter string for test: ");
            string input = Console.ReadLine();

            StringBuilder builder = new StringBuilder();
            builder.Append(input);
            Console.WriteLine(builder.Substring(1, 2));
            Console.WriteLine(builder.Substring(4));
        }
    }
}