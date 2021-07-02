using System;

namespace DateTime
{
    class Program
    {
        static void Main()
        {
            var dateTime = new System.DateTime(2015, 1, 1);
            var now = System.DateTime.Now;
            var today = System.DateTime.Today;

            Console.WriteLine($"Hours: {now.Hour}");
            Console.WriteLine($"Minutes: {now.Minute}");

            var tomorrow = now.AddDays(1);
            var yesterdat = now.AddDays(-1);

            Console.WriteLine($"Tomorrow: {now.ToString()}");
            Console.WriteLine($"To string formatter: {now.ToString("yy-MM-dd HH:mm")}");
            Console.WriteLine($"Tomorrow: {now.ToLongDateString()}");
            Console.WriteLine($"Tomorrow: {now.ToShortDateString()}");
            Console.WriteLine($"Tomorrow: {now.ToLongTimeString()}");
            Console.WriteLine($"Tomorrow: {now.ToShortTimeString()}");
            
        }
    }
}
