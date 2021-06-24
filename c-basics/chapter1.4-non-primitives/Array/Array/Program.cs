using System;

namespace Array
{
    class Program
    {
        static void Main()
        {
            var numbers = new int[3];

            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var strings = new string[3] { "John", "Snow", "" };

            Console.WriteLine(strings[0]);
            Console.WriteLine(strings[1]);
            Console.WriteLine(strings[2]);

            var flags = new bool[3];

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

        }
    }
}
