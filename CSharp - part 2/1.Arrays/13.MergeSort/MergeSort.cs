using System;

/*  Problem 13.* Merge sort
    Write a program that sorts an array of integers using the Merge sort algorithm.
 */

class MergeSort
{
    static void Main()
    {

        int[] arrayOfNumbers = { 1, 5, 9, 4, 8, 7, 2, 3, 6 };

        MergeSort merge = new MergeSort();
        merge.mergesort(arrayOfNumbers, 0, arrayOfNumbers.Length - 1);
        foreach (int a in arrayOfNumbers)
        {
            Console.Write(a + " ");
        }
        Console.WriteLine();
    }

    void mergesort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int mid = (end + start) / 2;
            mergesort(arr, start, mid);
            mergesort(arr, mid + 1, end);
            mergeArray(arr, start, mid, end);
        }
    }

    void mergeArray(int[] arr, int start, int mid, int end)
    {
        int[] temp = new int[end - start + 1];

        int i = start, j = mid + 1, k = 0;
        while (i <= mid && j <= end)
        {
            if (arr[i] < arr[j])
            {
                temp[k] = arr[i];
                k++;
                i++;
            }
            else
            {
                temp[k] = arr[j];
                k++;
                j++;
            }
        }
        while (i <= mid)
        {
            temp[k] = arr[i];
            k++;
            i++;
        }
        while (j <= end)
        {
            temp[k] = arr[j];
            k++;
            j++;
        }
        k = 0;
        i = start;
        while (k < temp.Length && i <= end)
        {
            arr[i] = temp[k];
            i++;
            k++;
        }
    }
}