using System;

namespace PassByReference
{
    class MainClass
	{
		//ref means address not value
		public void swap(ref int x, ref int y)
		{
			int temp = 0;
			temp = x;
			x = y;
			y = temp;
			Console.WriteLine("Inside the swap Method a = {0} " +
				" b= {1}", x, y);

		}

		static void Main(string[] args)
		{
			int a = 10;
			int b = 5;
			Console.WriteLine("Before method call values are" +
				"a ={0} & b ={1}", a, b);
			MainClass p = new MainClass();
			p.swap(ref a, ref b); //pass by reference 
								  // passing address of variables not copy
			Console.WriteLine("After method call values are" +
				"a ={0} & b ={1}", a, b);
			Console.Read();
		}
    }
}
