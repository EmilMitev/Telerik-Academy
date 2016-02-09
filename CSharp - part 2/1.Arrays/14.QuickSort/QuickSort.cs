using System;

/*  Problem 14. Quick sort
    Write a program that sorts an array of integers using the Quick sort algorithm.
 */

class QuickSort
{
    static void Main()
    {
        int[] arr = { 2, 14, 12, 8, 6, 9, 15, 4, 5, 1, 3, 11 };
        QuickSort qs = new QuickSort();
        qs.quicksort(arr, 0, arr.Length - 1);

        foreach (int x in arr)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }

    void quicksort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int pivotIndex = partition(arr, start, end);
            quicksort(arr, start, pivotIndex - 1);
            quicksort(arr, pivotIndex + 1, end);
        }
    }

    int partition(int[] arr, int start, int end)
    {
        int pivot = end;
        int i = start, j = end, temp;
        while (i < j)
        {
            while (i < end && arr[i] < arr[pivot])
                i++;
            while (j > start && arr[j] > arr[pivot])
                j--;

            if (i < j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        temp = arr[pivot];
        arr[pivot] = arr[j];
        arr[j] = temp;
        return j;
    }
}