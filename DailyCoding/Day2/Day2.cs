using System;

namespace Day2
{
    class Day2
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("(caution: Minimum Size should be 2 for accurate results)\n\nPlease Enter the Size of the List:  ");
            n = Convert.ToInt32(Console.ReadLine());
            int?[] A = new int?[n];
            Console.WriteLine("\nEnter natural numbers into the List:  ");
            ReadingArray(A, n);
            Console.WriteLine("\n\nNumbers entered are: ");
            PrintingArray(A, n);
            Console.WriteLine("\n\nThe Resulting Output List is: ");
            PrintingArray(NewArrayProduct(A, n), n);
            Console.ReadKey();
        }


        static void ReadingArray(int?[] A, int n)
        {
            for (int a = 0; a < n; a++)
                A[a] = Convert.ToInt32(Console.ReadLine());

        }

        static void PrintingArray(int?[] A, int n)
        {
            for (int a = 0; a < n; a++)
                Console.Write(A[a] + " ");
        }

        static int?[] NewArrayProduct(int?[] A, int n)
        {

            int?[] PrefixA = new int?[n];
            int?[] SuffixA = new int?[n];
            int g = 0;
            foreach (var a in A)
            {
                if (PrefixA[0].HasValue)
                    PrefixA[g] = PrefixA[g - 1] * a;
                else
                    PrefixA[g] = a;
                g++;
            }
            Array.Reverse(A);
            int e = 0;
            foreach (var a in A)
            {
                if (SuffixA[0].HasValue)
                    SuffixA[e] = SuffixA[e - 1] * a;
                else
                    SuffixA[e] = a;
                e++;
            }
            Array.Reverse(SuffixA);
            int?[] ResultA = new int?[n];
            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0)
                    ResultA[i] = (SuffixA[i + 1]);
                else if (i == A.Length - 1)
                    ResultA[i] = (PrefixA[i - 1]);
                else
                    ResultA[i] = (PrefixA[i - 1] * SuffixA[i + 1]);
            }
            return ResultA;
        }

    }
}
