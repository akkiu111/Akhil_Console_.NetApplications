using System;

namespace InsertionSortRecursion
{
    class InsertionSortingRecursion
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter Array Size: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Enter Elements into array:  ");
            ReadingArray(A, n);
            Console.WriteLine("Before InsertionSort Recursion : ");
            PrintingArray(A, n);
            InsertionSortRecursion(A, n);
            Console.WriteLine("\nAfter InsertionSort Recursion: ");
            PrintingArray(A, n);
            Console.ReadKey();
        }

        static void InsertionSortRecursion(int[] A, int n)
        {
            if (n == 0)
            {
                return;
            }

            InsertionSortRecursion(A, n - 1);

            int i, key;
            key = A[n - 1];
            i = n - 2;
            while (i >= 0 && A[i] > key)
            {
                A[i + 1] = A[i];
                i = i - 1;
            }
            A[i + 1] = key;

        }

        static void PrintingArray(int[] A, int n)
        {

            for (int a = 0; a < n; a++)
            {
                Console.Write(A[a] + " ");
            }
        }

        static void ReadingArray(int[] A, int n)
        {

            for (int a = 0; a < n; a++)
            {
                A[a] = Convert.ToInt32(Console.ReadLine());
            }
        }

    }
}
