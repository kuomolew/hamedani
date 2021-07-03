using System;
using System.Text;

namespace StringBuilder
{
    class Program
    {
        static void Main()
        {
            var str = "Hello World";
            var builder = new System.Text.StringBuilder(str);
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine(builder[0]);
        }
    }
}
