using System;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //adding();
            //subtracting();
            //multiplying();
            //dividing();
            moding();
            Console.Read();


        }

		public static void adding()
		{
			Console.WriteLine("+++adding+++");
			Console.WriteLine("Input first Num");
            int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Input second Num");
            int num2 = int.Parse(Console.ReadLine());
			Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        }

		public static void subtracting()
		{
			Console.WriteLine("---subtracting---");
			Console.WriteLine("Input first Num");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Input second Num");
			int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
		}

        public static void multiplying()
        {
            Console.WriteLine("***multiplying***");
            Console.WriteLine("Input first Num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second Num");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        }

        public static void dividing()
        {
            Console.WriteLine("~~~dividing~~~");
            Console.WriteLine("Input first Num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second Num");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        }

        public static void moding()
        {
            Console.WriteLine("~~~moding~~~");
            Console.WriteLine("Input first Num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second Num");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2);
        }
    }
}
