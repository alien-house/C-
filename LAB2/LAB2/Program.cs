using System;

namespace LAB2
{
    class MainClass
    {
        public static void Main(string[] args)
		{
			//task1();
            //task2();
            task3();
        }


		public static void task1()
		{

			int num = 5;
			for (int i = 0; i < num; i++)
			{
				for (int a = 0; a < i; a++)
				{
					Console.Write('*');
				}
				Console.WriteLine();
			}
			for (int i = 1; i < num + 1; i++)
			{
				for (int a = 1; a < i; a++)
				{
					Console.Write(String.Format("{0}", a));
				}
				Console.WriteLine();
			}
		}

        public static void task2()
        {
			Console.WriteLine("Input the size of the square matrix (less than 5):");
			int size = int.Parse(Console.ReadLine());
			//int size = 2;//今は２決め打ち
            Console.WriteLine("The size of the square matrix is {0} you enter",size);
			int[] sizes = new int[size];

			int[][][] box = new int[3][][];
			for (int index = 0; index < 3; index++)
			{
				box[index] = new int[size][];
                for (int i = 0; i < size; i++)
				{
					box[index][i] = new int[size];
                }
			}

			for (int index = 0; index < 2; index++)
			{
				Console.WriteLine("[Box{0}]------------ ", index);
				for (int i = 0; i < size; i++)
				{
					//Console.WriteLine("[{0}] ", i);
					for (int a = 0; a < size; a++)
					{
						box[index][i][a] = int.Parse(Console.ReadLine());
                        box[2][i][a] += box[index][i][a];
                        Console.Write("element - [{0}],[{1}] :", i, a);
						Console.WriteLine("{0} ", box[index][i][a]);
					}
				}
            }

			Console.WriteLine("==============================");

			for (int index = 0; index < 3; index++)
			{
				switch (index)
				{
					case 0:
						Console.WriteLine("The First matrix is: ");
						break;
					case 1:
						Console.WriteLine("The Second matrix is: ");
						break;
					case 2:
						Console.WriteLine("The Addition of two matrix is: ");
						break;
                }
				for (int i = 0; i < size; i++)
				{
					for (int a = 0; a < size; a++)
					{
						Console.Write("{0} ", box[index][i][a]);
                        if(a >= size - 1){
							Console.WriteLine("");
                        }
					}
				}
			}
			Console.WriteLine("==============================");


		}


        public static void task3()
		{
			int n, i = 0, num = 0, c;

			Console.Write("Enter a number:");
			n = int.Parse(Console.ReadLine());

			for (c = 1; c <= n+1; c++)
			{
                //Console.Write("{0}\n", Fibonacci(i));
                num = Fibonacci(i);
				i++;
			}
			//Console.Write("{0}\n", num);
            Console.Write("The Fibonacci of {0} th term is {1}", n, num);

		}

		public static int Fibonacci(int n)
		{
			if (n == 0)
				return 0;
			else if (n == 1)
				return 1;
			else
				return (Fibonacci(n - 1) + Fibonacci(n - 2));
		}

    }
}
