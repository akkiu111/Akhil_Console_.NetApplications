using System;

namespace Experimenting
{
    abstract class AbstractionFeatured
    {

        public void Method1()
        {
            Console.WriteLine("Public access specifier in Method1 with abstract class method");
            Console.WriteLine("");
        }

        public abstract void Method2();


        public static void Method3()
        {
            Console.WriteLine("Public access specifier in Method3 in abstract class");
            Console.WriteLine("");

        }

        internal void Method4()
        {
            Console.WriteLine("Internal access specifier in Method4 in abstract class called using abstract class reference pointed to derived class object");
            Console.WriteLine("");

        }

        //   public AbstractionFeatured();

        public AbstractionFeatured()
        {
            Console.WriteLine("This is abstract class constructor called from derived class object");
            Console.WriteLine("");

        }

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
            Console.WriteLine("");
        }

    }
}
