using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dis1 = new int[5];
            int[] dis2 = new int[5];
            int[] j1 = new int[] { 1, 2, 3, 4, 5 };
            int[] j2 = new int[] { 3, 2, 1, 4, 5 };
            for (int i = 0; i < 5; i++)
            {
                dis1[i] = j1[-i - 1] - j1[i] - 1;
            }

            for (int i = 0; i < 5; i++)
            {
                dis2[i] = j2[-i - 1] - j2[i] - 1;
            }


            Console.WriteLine();


        }
    }


}
