using System;

namespace Problem2_Array
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
			Console.Write("Input the number of elements to be stored in the array : ");
			int maxNum = int.Parse(Console.ReadLine());


			int[] numArray = new int[maxNum];
            //int[] numArrayFre = new int[maxNum];

            for (int i = 0; i < maxNum; i++){
                Console.WriteLine("element -{0}", i);
                int num = int.Parse(Console.ReadLine());
                numArray[i] = num;
            }
			int[] newNumArray = new int[maxNum];
			int[] timesArray = new int[maxNum];

            for (int i = 0; i < maxNum; i++)
			{
                int times = 0;
                for (int a = 0; a < maxNum; a++)
                {
                    if(numArray[i] == numArray[a]){
                        times++;
                    }
                }
                newNumArray[i] = numArray[i];
				timesArray[i] = times;
            }

            for (int i = 0; i < maxNum; i++)
			{
				Console.WriteLine("{0} occurs {1} times", newNumArray[i], timesArray[i]);
            }
        }
    }
}
