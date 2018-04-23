using System;

namespace JaggedArray
{
    class MainClass
    {

		static void Main(string[] args)
		{
			//Check a set of numbers and group them by their reminder 
			// when divided by 3 (0,1,2)
			//i.e :0,1,4,113,55,3,2,66,557,124
			int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
			int[] sizes = new int[3];
			//size[0] = columns? 
			//size[1] = columns? 
			//size[2] = columns? 
			foreach (var no in numbers) //var = variable & takes any data type  
			{
				int reminder = no % 3;
				sizes[reminder]++;
			}
			//create a jagged array
			int[][] numbersByReminder = new int[][]
			{
				new int[sizes[0]],
				new int[sizes[1]],
				new int[sizes[2]]
			};
			// fill the elements in jagged array ???
			// Repeate 1 to 3 for all numbers
			// 1. find the reminder = no % 3;
			// 2. find the index
			// 3. assign the element


            //-------------------------------
			int index1 = 0;
			int index2 = 0;
			int index3 = 0;
			foreach (var no in numbers) 
			{
				int reminder = no % 3;
                //numbersByReminder[reminder]
                //Console.Write("{0},{1}: ", i, k);
				switch (reminder)
				{
					case 0:
						numbersByReminder[reminder][index1] = no;
						index1++;
						break;
					case 1:
						numbersByReminder[reminder][index2] = no;
						index2++;
						break;
					case 2:
						numbersByReminder[reminder][index3] = no;
                        index3++;
						break;

                }
			}
            for (int i = 0; i < numbersByReminder.Length; i++)
            {
                Console.WriteLine("[{0}]", i);
                int num = numbersByReminder[i].Length;
                for (int k = 0; k < num; k++)
                { 
                    Console.Write("{0}: ", numbersByReminder[i][k]);
				}
				Console.WriteLine();
            }
			Console.Read();
		}
    }
}
