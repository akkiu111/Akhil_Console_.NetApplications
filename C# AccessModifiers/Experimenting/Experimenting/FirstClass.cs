using System;

namespace Experimenting
{
    // different access modifiers, abstract classes, inheritance, method over loading, static and dynamic constructors
    class FirstClass
    {
        public void Method1()
        {
            Console.WriteLine("Public access specifier in Method1");
            Console.WriteLine("");
        }

        private void Method2()
        {
            Console.WriteLine("Private access specifier in Method2");
            Console.WriteLine("");

        }

        protected void Method3()
        {
            Console.WriteLine("Protected access specifier in Method3");
            Console.WriteLine("");

        }

        internal void Method4()
        {
            Console.WriteLine("Internal access specifier in Method4");
            Console.WriteLine("");

        }


        protected internal void Method5()
        {
            Console.WriteLine("Protected Internal access specifier in Method5");
            Console.WriteLine("");

        }

        private protected void Method6()
        {
            Console.WriteLine("Private Protected access specifier in Method6");
            Console.WriteLine("");

        }

        internal protected void Method7()
        {
            Console.WriteLine("Internal Protected access specifier in Method7");
            Console.WriteLine("");


        }







        public static void staticMethod1()
        {
            Console.WriteLine("Public access specifier with static method named staticMethod1" +
                " is called directly with class(i.e, without creating an object for this class");
            Console.WriteLine("");

        }

        private static void staticMethod2()
        {
            Console.WriteLine("Private access specifier with static method named staticMethod2" +
                " is called directly with class(i.e, without creating an object for this class");
            Console.WriteLine("");

        }

        protected static void staticMethod3()
        {
            Console.WriteLine("Protected access specifier with static method named staticMethod3" +
                " is called directly with class(i.e, without creating an object for this class");
            Console.WriteLine("");

        }

        internal static void staticMethod4()
        {
            Console.WriteLine("Internal access specifier with static method named staticMethod4" +
                " is called directly with class(i.e, without creating an object for this class");
            Console.WriteLine("");

        }


        protected internal static void staticMethod5()
        {
            Console.WriteLine("Protected Internal access specifier with static method named staticMethod5" +
                " is called directly with class(i.e, without creating an object for this class");
            Console.WriteLine("");

        }

        private protected static void staticMethod6()
        {
            Console.WriteLine("Private Protected access specifier with static method named staticMethod6" +
                " is called directly with class(i.e, without creating an object for this class");
            Console.WriteLine("");

        }

        internal protected static void staticMethod7()
        {
            Console.WriteLine("Internal protected access specifier with static method named staticMethod7" +
                " is called directly with class(i.e, without creating an object for this class");
            Console.WriteLine("");


        }




    }
}
