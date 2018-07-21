using System;

namespace InsertionSort
{
    class InsertionSorting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Enter Elements into array:  ");
            ReadingArray(A, n);
            Console.WriteLine("Before Insertion Sort: ");
            PrintingArray(A, n);
            InsertionSort(A, n);
            Console.WriteLine("\nAfter Insertion Sort: ");
            PrintingArray(A, n);
            Console.ReadKey();
        }

        static void InsertionSort(int[] A, int n)
        {

            for (int j = 1; j < n; j++)
            {
                int i, key;
                key = A[j];
                i = j - 1;
                while (i >= 0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }
                A[i + 1] = key;
            }

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
