using System;

class TextToNumber
{
    static void Main()
    {
        long numberM = long.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        text = text.ToUpper();

        long result = 0;

        for (int i = 0; i < text.Length; i++)
        {
           char ch = text[i];
           if (ch == '@')
           {
               break;
           }
           else if (char.IsDigit(ch))
           {
               result *= Convert.ToInt64(ch.ToString());
           }
           else if (char.IsLetter(ch))
           {
               result += (long)ch-65;
           }
           else
           {
               result %= numberM;
           }
        }

        Console.WriteLine(result);
    }
}