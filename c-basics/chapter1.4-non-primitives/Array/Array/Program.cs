using System;

namespace Array
{
    class Program
    {
        static void Main()
        {
            //var numbers = new int[3];

            //numbers[0] = 1;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            var strings = new string[3] { "John", "Snow", "" };

            Console.WriteLine(strings[0]);
            Console.WriteLine(strings[1]);
            Console.WriteLine(strings[2]);

            var flags = new bool[3];

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine($"Length: {numbers.Length}");

            // IndexOf()
            var index = System.Array.IndexOf(numbers, 9);
            Console.WriteLine($"Index of 9: {index}");

            // Clear()
            System.Array.Clear(numbers, 0, 2);
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Copy()

            var another = new int[3];
            System.Array.Copy(numbers, another, 3);
            Console.WriteLine("Copy Effect");
            foreach (var number in another)
            {
                Console.WriteLine(number);
            }


            // Sort()
            System.Array.Sort(numbers);
            Console.WriteLine("Sort Effect");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Reverse()
            System.Array.Reverse(numbers);
            Console.WriteLine("Reverse Effect");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
