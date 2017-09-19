using System;
using System.Text;

namespace Exercises01
{
    class MainClass
    {
        public static void Main(string[] args)
		{
			exercise4();
   //         exercise5();
			//exercise1();
			//exercise2();
			//exercise3();
			//exerciseSample();
            Console.Read();
        }

        public static void exercise5()
        {
            int? intNum = null;
			double? doubleNum = null;
			Console.WriteLine("int? = {0}", intNum);
			Console.WriteLine("double? = {0}", doubleNum);
            intNum = 2;
			doubleNum = 2.2;
			Console.WriteLine("int? = {0}", intNum);
			Console.WriteLine("double? = {0}", doubleNum);
			intNum = null;
			doubleNum = null;
			Console.WriteLine("int? = {0}", intNum);
			Console.WriteLine("double? = {0}", doubleNum);
        }

        public static void exercise4()
        {
			char char1 = '@';
			Console.WriteLine("char = {0}", char1);

			Console.WriteLine("char = {0}", (decimal)char1);
			Console.WriteLine("char = {0}", (int)char1);

			char c = (char)65;
			char c2 = Convert.ToChar(65);
            string s = Encoding.ASCII.GetString(new byte[] { 65 });
			Console.WriteLine("c = {0}", c);
			Console.WriteLine("c2 = {0}", c2);
			Console.WriteLine("s = {0}", s);

			int unicode = 65;
			char character = (char)unicode;
			string text = character.ToString();
			Console.WriteLine("65 = {0}", unicode);
			Console.WriteLine("65 = {0}", character);
			Console.WriteLine("65 = {0}", text);

			//byte myValue = 255;
			//byte x = 10, y = 20;
			//char char1 = 'X';
			//char char2 = '\x0058';
			//char char3 = (char)88; //cast from integer value
			//char char4 = '\u0058';
			//Console.WriteLine("Byte values mybyte = {0}", myValue);
			//Console.WriteLine("Byte Values x = {0} and y={1} and myvalue ={2}", x, y, myValue);
			//Console.WriteLine("value for char1 = {0}", char1);
			//Console.WriteLine("value for char2 = {0}", char2);
			//Console.WriteLine("value for char3 = {0}", char3);
			//Console.WriteLine("value for char4 = {0}", char4);
			//char symbol = 'a';
			//Console.WriteLine("the code for {0} is : {1} ", symbol, (int)symbol);
		}


		public static void exercise1()
		{
			ushort ushortNum = 52130;
			sbyte sbtyeNum = -115;
			int intNum = 4825932;
			byte byteNum = 97;
			int intNum3 = -10000;
            
        }

		public static void exercise2()
		{
            float x = 5.3F;
            float z = 6.01F;
            bool equal = (x == z);

			Console.WriteLine(equal);


            float x2 = 0.000001f;
            float z2 = 0.000001f;
			bool equal2 = (x2 == z2);
			Console.WriteLine(x2);
			Console.WriteLine(z2);
			Console.WriteLine(equal2);

			double a = 0.22f;
			Console.WriteLine(a);
			float b = 0.22f;
			Console.WriteLine(b);
			decimal c = 0.22M;
			Console.WriteLine(c);


		}





        public static void exercise3()
		{
			String str1 = "Hello";
			String str2 = "World";
            Object obj = str1 + str2;
			String result = (String)obj;
			Console.WriteLine("exercise3:" + obj);
            Console.WriteLine("exercise3:"+result);
        }


        public static void exerciseSample()
		{
			Console.WriteLine("exerciseSample");
			double a = 1.0f;
			double b = 0.33f;
			double sum = 1.33f;
			bool equal = (a + b == sum); //true?
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine("Float calculation = a+b={0}" +
"sum ={1} equal ={2}", a + b, sum, equal);
			//Float calculation = a+b=1.33000001311302sum =1.33000004291534 equal =False


			//Example for decimal comparison 
			decimal aDecimal = 1.0M;
			decimal bDecimal = 0.33M;
			decimal sumDecimal = 1.33M;
			bool equalDecimal = (aDecimal + bDecimal == sumDecimal); //true?
			Console.WriteLine("Decimal calculation = a+b={0}" +
				"sum ={1} equal ={2}", aDecimal + bDecimal, sumDecimal,
equalDecimal);
			//Decimal calculation = a+b = 1.33sum = 1.33 equal = True
		}

	}
}
