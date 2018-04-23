using System;

namespace FormattedOutput
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double someVar = 1.234;
            Console.WriteLine("{0:00.0000}",someVar);

            double colaPrice = 1.20;
            string cola = "Coca Cola";


            // creating white space
            Console.WriteLine("{0,-15} | {1,15:F2}", cola, colaPrice);
            Console.Read();

        }
    }
}
