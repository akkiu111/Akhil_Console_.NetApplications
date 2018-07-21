using System;

namespace BubbleSort
{
    public class BubbleSorting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Enter Elements into array:  ");
            ReadingArray(A, n);
            Console.WriteLine("Before Bubble  Sort: ");
            PrintingArray(A, n);
            A = BubbleSort(A, n);
            Console.WriteLine("\nAfter Bubble Sort: ");
            PrintingArray(A, n);
            Console.ReadKey();
        }

        public static int[] BubbleSort(int[] A, int n)
        {

            int temp = 0;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {


                    if (A[i] > A[i + 1])
                    {
                        temp = A[i + 1];
                        A[i + 1] = A[i];
                        A[i] = temp;

                    }

                }

            }

            return A;
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

