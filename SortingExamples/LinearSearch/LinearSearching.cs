using System;

namespace LinearSearch
{
    class LinearSearching
    {
        static void Main(string[] args)
        {
            int n, inputNumber;
            Console.WriteLine("Enter Array Size: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Enter Elements into array:  ");
            ReadingArray(A, n);
            Console.WriteLine("Elements entered are: ");
            PrintingArray(A, n);
            Console.WriteLine("\nEnter the Element to be found: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            LinearSearch(A, inputNumber);

            Console.ReadKey();
        }

        static void LinearSearch(int[] A, int inputNumber)
        {
            int position = 0;
            bool found = false; ;
            for (int i = 0; i < A.Length; i++)
            {
                if (inputNumber == A[i])
                {
                    position = i + 1;
                    found = true;
                    break;
                }

            }

            if (found)
            {
                int index = position - 1;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nSuccess!!!!\n\nAfter Linear Search the Element is found at index: '" + index + "' which is at position: " + position + " ");
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
