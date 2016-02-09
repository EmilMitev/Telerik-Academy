using System;
using System.Collections.Generic;

/*  Problem 16.* Subset with sum S
    We are given an array of integers and a number S.
    Write a program to find if there exists a subset of the elements of the array that has a sum S.
 */

class SubsetWithSumS
{
    static void Main()
    {
        int[] array = { 1, 3, 6, 2 };
        SubsetSum(array);
    }

    static List<int> SubsetSum(int[] array)
    {
        List<int> sumList = new List<int>();
        List<string> numberList = new List<string>();
        string numbers = "";
        for (int i = 0; i < array.Length; i++)
        {
            sumList.Add(array[i]);

            numbers = array[i].ToString();
            numberList.Add(numbers);

            int listLenght = sumList.Count;

            for (int j = listLenght - 2; j >= 0; j--)
            {
                int temp = array[i] + sumList[j];
                sumList.Add(temp);

                numbers = array[i] + " + " + numberList[j];
                numberList.Add(numbers);
            }
            numbers = "";
        }
        return sumList;
    }
}