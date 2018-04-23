using System;

namespace OperationCondition
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

			ushort a1 = 3;              //00000011
			ushort b1 = 5;              //00000101
            Console.WriteLine(a1 | b1); //00000111 = 7

            Console.WriteLine(a1 << 1); //00000011 -> 000000110 = 12 //与えた数自分左へ移動する！
            Console.WriteLine(a1 << 2); //00001100
			Console.WriteLine(a1 >> 2); //00000000 = 0




			Console.Read();


        }
    }
}
