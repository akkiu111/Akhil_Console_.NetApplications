using System;

namespace examplewintoconsole
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Console.WriteLine("Please Enter Your Text here");
            string a = Console.ReadLine();
            Console.WriteLine("You have entered: " + a);
            Console.ReadLine();
        }
    }
}
