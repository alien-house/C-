using System;

namespace NumberConvertion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int numValue = -1;
            Console.WriteLine("enter a number between -2174836 to ...");
            string input = Console.ReadLine();

            try {
                numValue = Convert.ToInt32(input);
            }catch(FormatException e){
                Console.WriteLine("INPUT STRING IS NOT A SEQUENCE OF DIGITS");
            }finally{
                if(numValue < Int32.MaxValue){
                    Console.WriteLine("your new value is {0}", numValue + 1);
                }
            }



        }
    }
}
