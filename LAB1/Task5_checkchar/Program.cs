using System;

namespace Task5_checkchar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.Read();
            ques();

        }

        public static void ques(){


			string input;
			try
			{
				input = Console.ReadLine();

				//check the number
				int number1 = 0;
				bool canConvert = int.TryParse(input, out number1);
				if (canConvert == true)
				{
					Console.WriteLine("This is a number");
                }else{

					//check vowel
					switch (input[0])
					{
						case 'a':
						case 'e':
						case 'i':
						case 'u':
						case 'o':
							Console.WriteLine("That is vowel!!!");
							break;
						default:
							Console.WriteLine("any other symbol!!!");
							break;
					}

                }
			}
			catch (FormatException e)
			{
				Console.WriteLine("Exeption!" + e);
			}
			finally
			{
				ques();
			}
        }



    }
}
