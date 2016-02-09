using System;

/*  Problem 4. Print a Deck of 52 Cards
    Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
    The card faces should start from 2 to A.
    Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
 */

class PrintADeckOfFiftyTwoCards
{
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            switch (i)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.Write("{0,2} {1}, {0,2} {2}, {0,2} {3}, {0,2} {4}", i, (char)9824, (char)9827, (char)9829, (char)9830);
                    break;           
                case 11:
                    Console.Write("{0,2} {1}, {0,2} {2}, {0,2} {3}, {0,2} {4}", (char)(74), (char)9824, (char)9827, (char)9829, (char)9830);
                    break;           
                case 12:
                    Console.Write("{0,2} {1}, {0,2} {2}, {0,2} {3}, {0,2} {4}", (char)(81), (char)9824, (char)9827, (char)9829, (char)9830);
                    break;           
                case 13:
                    Console.Write("{0,2} {1}, {0,2} {2}, {0,2} {3}, {0,2} {4}", (char)(75), (char)9824, (char)9827, (char)9829, (char)9830);
                    break;           
                case 14:
                    Console.Write("{0,2} {1}, {0,2} {2}, {0,2} {3}, {0,2} {4}", (char)(65), (char)9824, (char)9827, (char)9829, (char)9830);
                    break;
            }
            Console.WriteLine();
        }
    }
}