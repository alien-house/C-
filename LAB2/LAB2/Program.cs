using System;

namespace LAB2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 5;
			for (int i = 0; i < num; i++)
			{
                for (int a = 0; a < i; a++)
				{
					Console.Write('*');
					//Console.Write(String.Format("{0, 10}", i));
				}
				Console.WriteLine();
            }
        }
    }
}
