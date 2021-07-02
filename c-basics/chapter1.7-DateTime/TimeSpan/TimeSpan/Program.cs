using System;

namespace TimeSpan
{
    class Program
    {
        static void Main()
        {
            var timeSpan = new System.TimeSpan(1, 2, 3);  //(hours, mins, secs)

            var timeSpan1 = new System.TimeSpan(1, 0, 0);
            var timeSpan2 =  System.TimeSpan.FromHours(1);

            Console.WriteLine(timeSpan);

            var start = System.DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine(duration);

            // Properties
            Console.WriteLine($"Minutes: {timeSpan.Minutes}");
            Console.WriteLine($"Total Minutes: {timeSpan.TotalMinutes}");

            // Add
            Console.WriteLine($"Add example: {timeSpan.Add(System.TimeSpan.FromMinutes(8))}");
            Console.WriteLine($"Subtrackt example: {timeSpan.Add(System.TimeSpan.FromMinutes(-2))}");

            // To string 
            Console.WriteLine($"To string: {timeSpan.ToString()}");

            // Parse
            Console.WriteLine($"Parse: {System.TimeSpan.Parse("04:02:03")}");

        }
    }
}
