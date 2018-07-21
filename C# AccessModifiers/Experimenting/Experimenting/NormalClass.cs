using System;

namespace Experimenting
{
    class NormalClass : INormal, INormalother
    {
        void INormal.Method1()
        {
            Console.WriteLine("This Method1 is implemented using interface INormal ");
            Console.WriteLine("");
        }

        void INormalother.Method1()
        {
            Console.WriteLine("This Method1 is implemented using interface INormalother ");
            Console.WriteLine("");


        }
    }
}

