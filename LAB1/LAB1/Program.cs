using System;

namespace LAB1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // Task 1
            //Console.WriteLine("Hello!");
            //Console.WriteLine("Shin!");

            //string test = "HElooo";
            //Console.WriteLine(test);
            //test = "erere";
            //Console.WriteLine(test);
            int i = 5;
            int j;
            func1(ref i);
            func2(out j);
            Console.WriteLine(i +" " +j);

		}
		static void func1(ref int x)
		{
			x = x * x;
		}
		static void func2(out int x)
		{
			x = 6;
			x = x * x;
		}
    }
}
