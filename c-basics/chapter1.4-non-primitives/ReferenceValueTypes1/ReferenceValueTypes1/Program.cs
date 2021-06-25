using System;

namespace ReferenceValueTypes1
{
    class Program
    {
        static void Main()
        {
            var a = 10;
            var b = a;
            b++;

            Console.WriteLine($"a - {a}, b - {b}");

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine($"array1 - {string.Join(", ", array1)}, array2 - {string.Join(", ", array2)}");
        }
    }
}
