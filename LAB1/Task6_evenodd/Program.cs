using System;

namespace Task6_evenodd
{
    class MainClass
    {
		public static void Main(string[] args)
		{
			ques();
		}

		public static void ques()
		{
			Console.WriteLine("input any number");
			string input;
			try
			{
				input = Console.ReadLine();

				//check the number
				int number1 = 0;
				bool canConvert = int.TryParse(input, out number1);
				if (canConvert == true)
				{   
                    int newNum = int.Parse(input);
                    if(newNum % 2 == 0){
                        Console.WriteLine("that is even number");
					}
					else
					{
						Console.WriteLine("that is odd number");
                    }

                }else{

                    Console.WriteLine("Do you think it's number?:(");
                }
				
			}
			catch (FormatException e)
			{
				Console.WriteLine("Exeption!" + e);
			}
			finally
			{
				Console.WriteLine("--------------------------");
				ques();
			}
		}

	}
}
