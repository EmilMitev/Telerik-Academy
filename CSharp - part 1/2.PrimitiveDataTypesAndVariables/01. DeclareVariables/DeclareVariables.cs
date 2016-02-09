using System;

/*  Problem 1. Declare Variables
    Declare five variables choosing for each of them the most appropriate of the types 
    byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 */
public class DeclareVariables
{
    public static void Main()
    {
        checked
        {
            ushort a = 52130;
            sbyte b = -115;
            int c = 4825932;
            sbyte d = 97;
            short e = -10000;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}