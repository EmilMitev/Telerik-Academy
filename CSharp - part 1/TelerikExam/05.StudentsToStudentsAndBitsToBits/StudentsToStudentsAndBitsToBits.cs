using System;

class StudentsToStudentsAndBitsToBits
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());

        long longestSequenceOfZeroes = 0;
        long longestSequenceOfOnes = 0;

        long countZero = 0;
        long countOne = 0;

        long rememberPointZero = 0;
        long rememberPointOnes = 0;

        for (int i = 0; i < N; i++)
        {
            long number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                number *= -1;
            }

            for (int j = 30 - 1; j >= 0; j--)
            {
                long mask = 1 << j;
                long nAndMask = number & mask;
                long bit = nAndMask >> j;

                if (rememberPointZero == rememberPointOnes)
                {
                    if (bit == 0)
                    {
                        rememberPointOnes = 0;
                        rememberPointZero = 1;
                        ++countZero;
                    }
                    else
                    {
                        if (countZero > longestSequenceOfZeroes)
                        {
                            longestSequenceOfZeroes = countZero;
                        }
                        countZero = 0;
                        rememberPointOnes = 1;
                        rememberPointZero = 0;
                        ++countOne;
                    }
                }
                else if (rememberPointZero > rememberPointOnes)
                {
                    if (bit == 0)
                    {
                        rememberPointOnes = 0;
                        rememberPointZero = 1;
                        ++countZero;
                    }
                    else
                    {
                        if (countZero > longestSequenceOfZeroes)
                        {
                            longestSequenceOfZeroes = countZero;
                        }
                        countZero = 0;
                        rememberPointOnes = 1;
                        rememberPointZero = 0;
                        ++countOne;
                    }
                }
                else if (rememberPointOnes > rememberPointZero)
                {
                    if (bit == 1)
                    {
                        rememberPointOnes = 1;
                        rememberPointZero = 0;
                        ++countOne;
                    }
                    else
                    {
                        if (countOne > longestSequenceOfOnes)
                        {
                            longestSequenceOfOnes = countOne;
                        }
                        countOne = 0;
                        rememberPointOnes = 0;
                        rememberPointZero = 1;
                        ++countZero;
                    }
                }
            }
        }

        if (countOne > longestSequenceOfOnes)
        {
            longestSequenceOfOnes = countOne;
        }

        if (countZero > longestSequenceOfZeroes)
        {
            longestSequenceOfZeroes = countZero;
        }

        Console.WriteLine(longestSequenceOfZeroes);
        Console.WriteLine(longestSequenceOfOnes);
    }
}