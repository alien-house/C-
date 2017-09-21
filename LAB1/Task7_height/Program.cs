using System;

namespace Task7_height
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			ques();
		}

		public static void ques()
		{
			Console.WriteLine("input your height!");
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
                    string text = "";
                    if(newNum < 150){
                        text = "Dwarf";
                    }else if(newNum < 165){
                        text = "Average Height";
					}
					else if (newNum <= 195)
					{
						text = "taller";
					}
					else
					{
						text = "Abnormal..";
                    }

					Console.WriteLine("You are " + text);


				}
				else
				{
					Console.WriteLine("Huh?");
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
