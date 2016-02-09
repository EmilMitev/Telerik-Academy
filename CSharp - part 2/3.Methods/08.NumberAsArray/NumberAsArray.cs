using System;
using System.Linq;
using System.Text;

/*  Problem 8. Number as array
    Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    Each of the numbers that will be added could have up to 10 000 digits.
 */

class NumberAsArray
{
    static void Main()
    {
        int firstNumber = 156;
        int secondNumber = 44;

        string number = ArraysOfDigits(firstNumber, secondNumber);
        Console.WriteLine(number);
    }

    static string ArraysOfDigits(int firstNumber, int secondNumber)
    {
        int[] array1 = new int[10000];
        int[] array2 = new int[10000];

        array1 = NumberToArray(firstNumber);
        array2 = NumberToArray(secondNumber);

        Array.Reverse(array1);
        Array.Reverse(array2);

        int[] sumArray = new int[10000];
        int i = 0;
        int temp = 0;
        int someNumber = 0;

        while (true)
        {
            temp = 0;
            temp = array1[i] + array2[i] + someNumber;
            if (temp >= 10)
            {
                temp = temp % 10;
                sumArray[i] = temp;
                someNumber = 1;
            }
            else
            {
                sumArray[i] = temp;
                someNumber = 0;
            }
            ++i;
            if (i == array1.Length - 1)
            {
                break;
            }
        }
        StringBuilder builder = new StringBuilder();

        for (int j = array1.Length - 1; j >= 0; j--)
        {
            if (sumArray[j] != 0)
            {
                for (int k = j; k >= 0; k--)
                {
                    builder.Append(sumArray[k]);
                }
                break;
            }
        }
        return builder.ToString();
    }

    static int[] NumberToArray(int number)
    {
        int[] array = new int[10000];

        int temp;
        int tempNumber = number;
        int i = array.Length - 1;

        while (true)
        {
            temp = tempNumber % 10;
            tempNumber /= 10;
            array[i] = temp;
            --i;

            if (tempNumber == 0)
            {
                break;
            }
        }
        return array;
    }
}