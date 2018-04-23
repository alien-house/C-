using System;

namespace OptionalParameters
{
    class MainClass
    {

        public void Method(out int i, out string s1, out string s2){
            i = 44;
            s1 = "I have been";
            s2 = null;
        }

        public void PrintNumber(int start = 0, int end = 20){
            for (int i = start; i <= end; i++){
                Console.Write("{0} ",i);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MainClass p = new MainClass();
			//p.PrintNumber();
			//p.PrintNumber(5, 10);
            //p.PrintNumber(end:40, start:20);

			int value1;
			string value2;
			string value3;
			p.Method(out value1, out value2, out value3);
			Console.WriteLine(value1);
			Console.WriteLine(value2);
			Console.WriteLine(value3);


        }
    }
}
