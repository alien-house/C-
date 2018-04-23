using System;

namespace WhileLoop
{
    class MainClass
	{
		static void Main(string[] args)
		{
			//Entry controlled loop
			//1. Intialization
			//2. Condition
			//3. Increment/ Decrement
			int i = 51;
			Console.WriteLine("series from 1 to 50");
			while (i <= 50)
			{
				Console.Write("\t{0}", i);
				i++;
			}
			//?how many time??? 50 times

			//exit Controlled loop Do...While();
			int j = 51;
			Console.WriteLine();
			Console.WriteLine("Using Do while loop series from 1 to 50");
			do
			{
				Console.Write("\t{0}", j);
				j++;
			} while (j <= 50);


			Console.Read();
		}
    }
}
