using System;

namespace Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("convert from Celsius degrees to Kelvin and Fahrenheit.");

            double celsius = 10.0;
            double kelvin = celsius + 273;
            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("Celsius:{0:00.00}, Kelvin:{1:00.00}, Fahrenheit:{2:00.00}", celsius, kelvin, fahrenheit);

        }
    }
}
