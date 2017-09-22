using System;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

			Console.WriteLine("Input first Num");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Input second Num");
			int num2 = int.Parse(Console.ReadLine());

			Console.WriteLine("Input the first number:{0}", num1);
			Console.WriteLine("Input the second number:{0}", num2);
            adding(num1, num2);
            subtracting(num1, num2);
            multiplying(num1, num2);
            dividing(num1, num2);
            moding(num1, num2);
            Console.Read();


        }

		public static void adding(int num1, int num2)
		{
			Console.WriteLine("+++adding+++");
			Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        }

		public static void subtracting(int num1, int num2)
		{
			Console.WriteLine("---subtracting---");
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
		}

        public static void multiplying(int num1, int num2)
        {
            Console.WriteLine("***multiplying***");
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        }

        public static void dividing(int num1, int num2)
        {
            Console.WriteLine("~~~dividing~~~");
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        }

        public static void moding(int num1, int num2)
        {
            Console.WriteLine("~~~moding~~~");
            Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2);
        }
    }
}
