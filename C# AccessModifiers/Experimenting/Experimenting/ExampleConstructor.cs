using System;

namespace Experimenting
{
    class ExampleConstructor
    {
        public ExampleConstructor()
        {
            int a;
            int b;
            Console.WriteLine("THIS is default constructor");
            Console.WriteLine("");

        }

        public ExampleConstructor(string a, string b)
        {
            Console.WriteLine("This is Parametirised Constructor and I passed arguments from main method. They are " + a + " and " + b);
            Console.WriteLine("");
        }
    }
}
