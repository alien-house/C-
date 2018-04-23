using System;

namespace MultiDimensionalArray
{
    class MainClass
    {

		static void Main(string[] args)
		{
			//Matrix :two dimensional array 2*3
			//values always assigned row by row
			//     0  1   2 
			// 0| 11  22 33 |
			// 1| 44  55 66 |
			//first element 11 = [0][0]
			//third element 33 = [0][2]
			//index represented as [row][column]
			//read the matrix dimension
			Console.Write("Number of rows = ");
			int rows = int.Parse(Console.ReadLine());
			Console.Write("Number of Columns = ");
			int cols = int.Parse(Console.ReadLine());
			int page = 2;
			int[,] matrix = new int[rows, cols];
			//allocate the matrix
			// int[, ,] matrix = new int[rows , cols , page]; //not new int[][]
			//enetr the elements
			for (int i = 0; i < rows; i++) //outerloop is for row
			{
				for (int j = 0; j < cols; j++) //innner loop for column
				{
					Console.Write("Matrix[{0},{1}]  = ", i, j);
					int element = int.Parse(Console.ReadLine());
					matrix[i, j] = element;
				}
			}
			//Print the matrix on console
			Console.WriteLine();
			Console.WriteLine("The matrix isa s follow :");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write("{0}  ", matrix[i, j]);
				}
				Console.WriteLine();
			}


			Console.Read();
		}
    }
}
