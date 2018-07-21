using System;

namespace ATM_transaction
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalOneHundred = 1000, totalFiveHundred = 1000, totalOneThousand = 1000;
            int withdrawAmount, totalAmount;
            int thousands = 0, fiveHundreds = 0, oneHundreds = 0;
            totalAmount = (totalOneThousand * 1000 + totalFiveHundred * 500 + totalOneHundred * 100);

            do
            {
                Console.WriteLine("Please Enter the Amount you want to Withdraw only in multiples of 100's ");
                withdrawAmount = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (withdrawAmount % 100 != 0);


            if ((withdrawAmount >= 1000) && (withdrawAmount <= totalAmount))
            {
                thousands = withdrawAmount / 1000;
                if (thousands > totalOneThousand)
                {

                    thousands = totalOneThousand;
                }

                withdrawAmount = withdrawAmount - thousands * 1000;

            }

            if (withdrawAmount >= 500)
            {
                fiveHundreds = withdrawAmount / 500;
                if (fiveHundreds > totalFiveHundred)
                {
                    fiveHundreds = totalFiveHundred;
                }

                withdrawAmount = withdrawAmount - fiveHundreds * 500;


            }

            if (withdrawAmount >= 100)
            {
                oneHundreds = withdrawAmount / 100;
                if (oneHundreds > totalOneHundred)
                {

                    oneHundreds = totalOneHundred;
                }
                withdrawAmount = withdrawAmount - oneHundreds * 100;

            }


            Console.WriteLine("Total 1000 note: " + thousands);
            Console.WriteLine("Total  500 note: " + fiveHundreds);
            Console.WriteLine("Total  100 note: " + oneHundreds);
            Console.WriteLine("Thanks for your Transaction\n");

        }
    }


}

