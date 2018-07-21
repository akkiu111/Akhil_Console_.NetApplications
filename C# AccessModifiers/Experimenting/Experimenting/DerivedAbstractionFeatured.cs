using System;

namespace Experimenting
{
    class DerivedAbstractionFeatured : AbstractionFeatured
    {
        public override void Method2()
        {
            Console.WriteLine("This is implemented using derived class and the method is inherited from from abstract class");
            Console.WriteLine();
        }


        public static void Method3()
        {
            Console.WriteLine(" Method3 in derived class that inherits from abstract class is called only by class name");
            Console.WriteLine("");

        }


        public static void Method8()
        {
            Console.WriteLine(" Method8 in derived class that inherits from abstract class is called only by class name");
            Console.WriteLine("");

        }

        public void Addition()
        {
            Add(5, 3);
        }

        public void Adding()
        {
            Addition();
        }

        //public AbstractionFeatured()
        //{
        //    Console.WriteLine("This is abstract class constructor called from derived class object");
        //    Console.WriteLine("");

        //}





    }
}
