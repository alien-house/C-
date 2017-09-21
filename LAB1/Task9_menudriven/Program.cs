using System;

namespace Task9_menudriven
{
    class MainClass
    {
		public static void Main(string[] args)
		{
			ques();
		}

		public static void ques()
		{
			string input;
			string input2;
			try
			{
				Console.WriteLine("input first number!");
				input = Console.ReadLine();
				Console.WriteLine("input second number!");
				input2 = Console.ReadLine();

				//check the number
				int number1 = 0;
				bool canConvert = int.TryParse(input, out number1);
				bool canConvert2 = int.TryParse(input2, out number1);
                if (canConvert == true && canConvert2 == true)
                {
					int numFirst = int.Parse(input);
					int numSecond = int.Parse(input2);

					Console.WriteLine("=======================");
					Console.WriteLine("Here are the options:");
					Console.WriteLine("1-Addition.");
					Console.WriteLine("2-Substraction.");
					Console.WriteLine("3-Multiplication.");
					Console.WriteLine("4-Division.");
					Console.WriteLine("5-Exit.");
					Console.WriteLine("-----------------------");
                    int cntl = int.Parse(Console.ReadLine());
                    double answer = 0.0;
                    string ans_text = "";
                    switch(cntl){
                        case 1:
                            answer = numFirst + numSecond;
                            ans_text = "Addition";
							break;
						case 2:
							answer = numFirst - numSecond;
							ans_text = "Substraction";
							break;
						case 3:
							answer = numFirst * numSecond;
							ans_text = "Multiplication";
							break;
						case 4:
							answer = numFirst / numSecond;
							ans_text = "Division";
							break;
						case 5:
							throw new System.ArgumentException("Parameter cannot be null", "original");
                        default:
                            break;
                    }

					Console.WriteLine("Input your choice :" + cntl);
					Console.WriteLine("The " + ans_text + " of " + numFirst + " and " + numSecond + " is: " + answer);

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
