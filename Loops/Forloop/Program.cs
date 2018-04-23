using System;

namespace Forloop
{
    class MainClass
    {
		static void Main(string[] args)
		{
			//Factorial 2! = 2 *1 = 2
			//Factorial 3! = 3*2*1 = 6
			//Factorial 4! = 4*3*2*1 = 24
			// Factorial 5! = 5*4*3*2*1 = 120

			//intialization ; condition; increment/decrement
			int n = 20;
			decimal factorial = 1;
			for (int i = n; i >= 1; i--)
			{
				factorial = factorial * i;
			}
			Console.WriteLine("{0}! = {1}", n, factorial);
			//variation of for loop
			//For-each loop
			Console.WriteLine("For each example");
			string[] dayName = new string[]
			{
				"MONDAY","TUESDAY","WEDNESDAY",
				"THURSDAY","FRIDAY","SATURDAY",
				"SUNDAY"
			};
			///datatype variable keyword(in) collection_name
			//foreach is used over collections i.g list, arrays, 
			// maps,sets
			foreach (string day in dayName)
			{
				Console.WriteLine(day);

			}


			Console.Read();


		}
	}
}
