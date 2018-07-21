using System;

namespace Day1_SumOfTwo
{
    class Day1
    {
        static void Main(string[] args)
        {

            int n, inputNumber;
            Console.WriteLine("(caution: Minimum Size should be 2 for accurate results)\n\nPlease Enter the Size of the list:  ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("\nEnter natural numbers into the list:  ");
            ReadingArray(A, n);
            Console.WriteLine("\n\nNumbers entered are: ");
            PrintingArray(A, n);
            Console.WriteLine("\n\nEnter the input value that matches the sum of any two numbers in the list: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            bool result = SumSearch(A, inputNumber);
            CheckResult(result, inputNumber);
            Console.ReadKey();
        }


        static void ReadingArray(int[] A, int n)
        {
            for (int a = 0; a < n; a++)
            {
                A[a] = Convert.ToInt32(Console.ReadLine());
            }

        }
        static void PrintingArray(int[] A, int n)
        {
            for (int a = 0; a < n; a++)
            {
                Console.Write(A[a] + " ");
            }
        }

        static bool SumSearch(int[] A, int inputNumber)
        {

            bool result = false;
            for (int i = 0; i < A.Length; i++)
            {
                //Storing the result of the modulus of the inputnumber with each element of array
                int remainder = inputNumber % A[i];

                //Comparing the result of the modulus to each element in the array

                if (remainder + A[i] == inputNumber && remainder != 0)
                {
                    result = true;
                    break;
                }



            }

            return result;

        }

        static void CheckResult(bool result, int inputNumber)
        {
            if (result == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n" + result + "!!!!\n\nThe input value '" + inputNumber + "' matches the sum of two numbers present in the list");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + result + "!!!!\n\nThe input value '" + inputNumber + "' doesn't match the sum of two numbers present in the list");
            }
        }
    }
}
