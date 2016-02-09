using System;

class MaximalSum
{
    static void Main()
    {
        int[] arrayOfNumbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int sum = arrayOfNumbers[0];
        int bestSum = int.MinValue;
        int bestStart = 0;
        int bestLen = 1;
        int start = 0;
        int len = 1;

        for (int i = 1; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] >= sum + arrayOfNumbers[i])
            {
                start = i;
                len = 1;
                sum = arrayOfNumbers[i];
            }
            else
            {
                len++;
                sum += arrayOfNumbers[i];
            }

            if ((sum > bestSum) ||
                (sum == bestSum && len < bestLen) ||
                (sum == bestSum && len == bestLen && start < bestStart))
            {
                bestStart = start;
                bestLen = len;
                bestSum = sum;
            }
        }

        Console.Write("Result is: ");
        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            if (i == bestStart + bestLen - 1)
            {
                Console.Write(arrayOfNumbers[i]);
            }
            else
            {
                Console.Write("{0}, ", arrayOfNumbers[i]);
            }
        }
        Console.WriteLine();
    }
}