using System;

namespace Task2_Matrices
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the size of the square matrix (less than 5):");
			int size = int.Parse(Console.ReadLine());
            int squreSize = 2;
			Console.WriteLine("------------");
            int[] sizes = new int[size];

            int[][][] box = new int[size][][];
            for (int index = 0; index < size; index++)
            {
                box[index] = new int[3][];
            }

            for (int index = 0; index < size; index++)
			{
				Console.WriteLine("[{0}]=============== ", index);
                for (int i = 0; i < squreSize; i++)
                {
                    Console.WriteLine("[{0}] ", i);
                    box[index][i] = new int[2];
                    for (int a = 0; a < squreSize; a++)
                    {
						box[index][i][a] = int.Parse(Console.ReadLine());
                        Console.Write("{0}{1} :", i, a);
                        Console.WriteLine("{0} ", box[index][i][a]);
                    }
                }
            }


        }
    }
}
