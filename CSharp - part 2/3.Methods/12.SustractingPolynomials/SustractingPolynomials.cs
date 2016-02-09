using System;

class SustractingPolynomials
{
    static void Main()
    {
        Console.WriteLine("Add size of polynomials: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter polynomial 1 index {0}", i);
            arr1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter polynomial 2 index {0}", i);
            arr2[i] = int.Parse(Console.ReadLine());
        }

        int[] res = AddPolynomial(arr1, arr2);

        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine("Result adds polynomial index {0} = {1}", i, res[i]);
        }
        res = MultiplicationPolynomial(arr1, arr2);
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine("Result multiplication polynomial index {0} = {1}", i, res[i]);
        }
        res = SubtractionPolynomial(arr1, arr2);
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine("Result substraction polynomial index {0} = {1}", i, res[i]);
        }
    }

    static int[] AddPolynomial(int[] arr1, int[] arr2)
    {
        int[] res = new int[arr1.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            res[i] = arr1[i] + arr2[i];
        }

        return res;
    }

    static int[] MultiplicationPolynomial(int[] arr1, int[] arr2)
    {
        int[] res = new int[arr1.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            res[i] = arr1[i] * arr2[i];
        }

        return res;
    }

    static int[] SubtractionPolynomial(int[] arr1, int[] arr2)
    {
        int[] res = new int[arr1.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            res[i] = arr1[i] - arr2[i];
        }

        return res;
    }
}