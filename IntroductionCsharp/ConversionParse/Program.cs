using System;

namespace ConversionParse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("float b = ");
			float f = float.Parse(Console.ReadLine());
			Console.WriteLine("double d = ");
			double d = double.Parse(Console.ReadLine());

            Console.WriteLine("{0},{1},{2}", a, f, d);


        }
    }
}
