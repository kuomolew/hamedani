using System;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            //for (var i = 10; i >= 1; i-- )
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(input);
                    continue;
                }
                break;
                
            }

            var name = "John Smith";
            foreach(var character in name)
            {
                Console.WriteLine(character);
            }
        }
    }
}
