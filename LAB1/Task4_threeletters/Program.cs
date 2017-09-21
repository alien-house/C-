using System;

namespace Task4_threeletters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = "";
			try
			{
				input = Console.ReadLine();
                if(input.Length > 3){

                    Console.WriteLine("input within 3 letters : " + input);
					throw new System.ArgumentException("Parameter cannot be null", "original");

                }

            }catch(FormatException e){

				Console.WriteLine("Exeption!" + e);
            }finally{

				Console.WriteLine("word you input : " + input);
				Console.Write("reverse : ");
                int charLength = input.Length - 1;
                for (int i = charLength; i >= 0; i--){
                    Console.Write(input[i]);
                }
     //           foreach(char item in input){
					//Console.Write(item);
                //}

            }
            Console.Read();

        }
    }
}
