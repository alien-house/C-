using System;

namespace OneDimentionalArray
{
    /*
        - Collection of same type element
        - Index always start = 0
        - Dydnamic array NOT possible give it size
    */
    class MainClass
    {
        public static void Main(string[] args)
		{
			//one dimensional array 
			string[] cities = new string[10];
			cities[0] = "Vancouver";
			cities[1] = "Richmond";
			cities[2] = "Burnbay";
			//or
			string[] citiesName = {"VANCOUVER","LANGLEY","SURREY" ,
					"KELOWNA","RICHMOND","NEW WESTMINISTER","COQUITLAM"};
			Console.WriteLine("Unsorted : {0} ", string.Join(" , ", citiesName));
			Array.Sort(citiesName);
			Console.WriteLine("Sorted : {0} ", string.Join(" , ", citiesName));
			Console.WriteLine("size of array is  {0}", citiesName.Length);
			// binary search
			// 0. values must be sorted in ascending
			// use binarysearch..
			/*
                target = "dd"
                1. Find Mid-Element
                2. Compare
                3. Select Left half
                If net matching
                - Less than choose left half list
                - Creates than chosse Right half list
                - Repeat begining
            */
			// Result give you the index value if target is presnet otherwise -1.
			string target = "RICHMOND";
			int index = Array.BinarySearch(citiesName, target);
			Console.WriteLine("{0} element is fount at index {1}", target, index);
			Console.Read();



        }
    }
}
