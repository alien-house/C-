using System;
using System.Collections.Generic;

namespace Comparators
{
    class MainClass
    {

        private class numberReminder6Comparator : IComparer<int>
        {
            public int Compare(int x, int y)
			{
                return (x % 6).CompareTo(y % 6);
				//return x.CompareTo(y); // normal sort
            }
        }

        //1. create a NumberComparator class that imlements IComparer<int>
        //2. compare using module 6
        private class StudentComparator : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                // use var for reference data type (i.e. structures, object)
                // if value datatype than use the data type not var
				var lastName1 = x.Substring(x.IndexOf(' ') + 1);
				var lastName2 = y.Substring(y.IndexOf(' ') + 1);
                return lastName1.CompareTo(lastName2);
            }
        }

        public static void Main(string[] args)
		{
			int[] numbers = { 2, 12, 5, 10, 11, 1 };
			Console.WriteLine("Numbers Sorted by module 6");
			//using lamdba expression
			//Array.Sort(numbers, (x, y) => (x % 6).CompareTo(y % 6));
			//excercise : use the IComparer interface for sorting here

			Array.Sort(numbers, new numberReminder6Comparator());
			Console.WriteLine("output ");
			foreach (int no in numbers)
			{
				Console.Write("{0}\t", no);
			}

			Console.WriteLine();
			Console.WriteLine("=========================");
			//Sorting by last name
			string[] students = {
                "Doncho Mikov", 
                "Nikola Kostov",
				"Ivaylo Kenoz",
                "Evalogi Hristov"
            };
			Console.WriteLine("students sorted by first letter of their last name");
			Array.Sort(students, new StudentComparator());
			foreach (string studentname in students)
			{
				Console.WriteLine(studentname);
			}

			Console.Read();

        }
    }
}
