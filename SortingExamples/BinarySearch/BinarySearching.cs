using BubbleSort;
using System;

namespace BinarySearch
{
    class BinarySearching
    {
        static void Main(string[] args)
        {
            int n, key;
            Console.WriteLine("Enter Array Size: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Enter Elements into array:  ");
            ReadingArray(A, n);
            Console.WriteLine("Elements entered are: ");
            PrintingArray(A, n);
            A = BubbleSorting.BubbleSort(A, n);
            Console.WriteLine("\nElements After sorted are: ");
            PrintingArray(A, n);
            Console.WriteLine("\nEnter the Element to be found: ");
            key = Convert.ToInt32(Console.ReadLine());
            BinarySearch(A, key);
            Console.ReadKey();
        }

        static void BinarySearch(int[] A, int key)
        {
            int left = 0, index = -1, position = -1;
            bool found = false;
            int right = A.Length - 1;
            int mid = (left + right + 1) / 2;

            while (left <= right)
            {
                if (A[mid] == key)
                {
                    index = mid;
                    found = true;
                    break;

                }
                else if (key < A[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                    mid = (left + right + 1) / 2;
                }


            }
            if (found)
            {
                position = index + 1;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nSuccess!!!!\n\nAfter Binary Search the Element is found at index: '" + index + "' which is at position: " + position + " ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nOops!!!!!!\n\nYour entered input element doesn't match with any elements in the array ");
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
