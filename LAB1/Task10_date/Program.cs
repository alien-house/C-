using System;

namespace Task10_date
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			DateTime date = new DateTime();
			Console.WriteLine(date);

			DateTime now = DateTime.Now;
			Console.WriteLine(now);

            Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy")); // 05 / 29 / 2015
            Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy")); // Friday, 29 May 2015
			Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy")); // Friday, 29 May 2015 05:50
			Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy")); // Friday, 29 May 2015 05:50 AM
			Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy")); // Friday, 29 May 2015 5:50
			Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy")); // Friday, 29 May 2015 5:50 AM
			Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")); //    Friday, 29 May 2015 05:50:06
			Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm")); //   05 / 29 / 2015 05:50
			Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")); //    05 / 29 / 2015 05:50 AM
			Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy H:mm")); //    05 / 29 / 2015 5:50
			Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy h:mm tt")); // 05 / 29 / 2015 5:50 AM
			Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")); //    05 / 29 / 2015 05:50:06
			Console.WriteLine(DateTime.Now.ToString("MMMM dd")); //    May 29
			Console.WriteLine(DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK")); // 2015 - 05 - 16T05: 50:06.7199222 - 04:00
			Console.WriteLine(DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’")); // Fri, 16 May 2015 05:50:06 GMT
			Console.WriteLine(DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss")); //  2015 - 05 - 16T05: 50:06
			Console.WriteLine(DateTime.Now.ToString("HH:mm")); //  05:50
			Console.WriteLine(DateTime.Now.ToString("hh:mm tt")); //   05:50 AM
			Console.WriteLine(DateTime.Now.ToString("H:mm")); //   5:50
			Console.WriteLine(DateTime.Now.ToString("h:mm tt")); //    5:50 AM
			Console.WriteLine(DateTime.Now.ToString("HH:mm:ss")); //   05:50:06
			Console.WriteLine(DateTime.Now.ToString("yyyy MMMM")); //  2015 May
												//System.Diagnostics.Debug.WriteLine("This is a message for Debugging.");


            Console.Read();
		}
    }
}
