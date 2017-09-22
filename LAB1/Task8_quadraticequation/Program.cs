using System;

namespace Task8_quadraticequation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int determinant;
            double root1, root2 = 0;
			int b = 3;
			int a = 2;
			int c = 1;

            Console.WriteLine("b:{0}, a:{1}, c:{2}",b,a,c);
            determinant = b * b - 4 * a * c;
            Console.WriteLine("determinant is {0}",determinant);

            if (determinant > 0)
            {
				Console.WriteLine("the roots are real and different");
				root1 = (-b + Math.Sqrt(determinant)) / (2 * a);
				root2 = (-b - Math.Sqrt(determinant)) / (2 * a);
				Console.WriteLine("First root is:" + root1);
				Console.WriteLine("Second root is:" + root2);
            }
            else if (determinant == 0){
				Console.WriteLine("the roots are real and equal.");
				root1 = (-b + Math.Sqrt(determinant)) / (2 * a);
				Console.WriteLine("Root:" + root1);
			}
			else
			{
				Console.WriteLine("the roots are complex and different.");
            }

        }
    }
}
