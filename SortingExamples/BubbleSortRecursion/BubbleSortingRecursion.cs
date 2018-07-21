using System;

namespace BubbleSortRecursion
{
    class BubbleSortingRecursion
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter Array Size: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Enter Elements into array:  ");
            ReadingArray(A, n);
            Console.WriteLine("Before Bubble  Sort Recursion : ");
            PrintingArray(A, n);
            BubbleSorting(A, n);
            Console.WriteLine("\nAfter Bubble Sort Recursion: ");
            PrintingArray(A, n);
            Console.ReadKey();
        }

        static void BubbleSorting(int[] A, int n)
        {
            if (n == 0)
            {
                return;
            }
            int temp = 0;


            for (int i = 0; i < n - 1; i++)
            {


                if (A[i] > A[i + 1])
                {
                    temp = A[i + 1];
                    A[i + 1] = A[i];
                    A[i] = temp;

                }

            }
            BubbleSorting(A, n - 1);

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

