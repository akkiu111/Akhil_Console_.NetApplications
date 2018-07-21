namespace Experimenting
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass fc = new FirstClass();
            fc.Method1();
            //  fc.Method2();
            //  fc.Method3();
            fc.Method4();
            fc.Method5();
            // fc.Method6();
            fc.Method7();


            FirstClass.staticMethod1();
            //   FirstClass.staticMethod2();
            //   FirstClass.staticMethod3();
            FirstClass.staticMethod4();
            FirstClass.staticMethod5();
            //  FirstClass.staticMethod6();
            FirstClass.staticMethod7();

            Alpha a = new Alpha();
            a.Method1();
            a.Method4();
            a.Method5();
            a.Method7();

            Alpha.staticMethod1();
            //Alpha.staticMethod2();
            //Alpha.staticMethod3();
            Alpha.staticMethod4();
            Alpha.staticMethod5();
            //Alpha.staticMethod6();
            Alpha.staticMethod7();



            //AbstractionFeatured.Method4();


            DerivedAbstractionFeatured daf = new DerivedAbstractionFeatured();
            daf.Method1();
            daf.Method2();
            daf.Adding();


            //daf.Method3();
            DerivedAbstractionFeatured.Method3();
            //daf.Method8();
            DerivedAbstractionFeatured.Method8();

            //AbstractionFeatured abf = new AbstractionFeatured();
            //abf.Method1();

            //DerivedAbstractionFeatured abf = new AbstractionFeatured();
            //abf.AbstractionFeatured();

            AbstractionFeatured abf = new DerivedAbstractionFeatured();
            abf.Method4();
            //abf.AbstractionFeatured();

            //daf.AbstractionFeatured();

            AbstractionFeatured.Method3();


            //ExampleConstructor();
            //ExampleConstructor("", "");

            ExampleConstructor ec = new ExampleConstructor();
            ExampleConstructor ecp = new ExampleConstructor("Akhil", "K");


            //NormalClass nc = new NormalClass();
            //nc.Method1();

            INormal n1 = new NormalClass();
            INormalother n2 = new NormalClass();
            n1.Method1();
            n2.Method1();




        }
    }
}
