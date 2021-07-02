using System;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            var fullName = "John Snow ";

            //trim
            Console.WriteLine($"No trim: '{fullName}', trim: '{fullName.Trim()}'");

            // toupper
            Console.WriteLine($"ToUpper: '{fullName.Trim().ToUpper()}'");

            // substring split
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine($"Index variant. First name: '{firstName}', Last Name: '{lastName}'");

            // .Split split
            fullName = fullName.Trim();
            var names = fullName.Split(' ');
            firstName = names[0];
            lastName = names[1];
            Console.WriteLine(names.Length);
            Console.WriteLine($"Split variant. First name: '{firstName}', Last Name: '{lastName}'");

            //replace
            Console.WriteLine(fullName.Replace("o", "a"));

            // empty strings
            var empty = "";
            var space = " ";
            if (String.IsNullOrEmpty(empty))
                Console.WriteLine("Invalid message1");
            if (String.IsNullOrEmpty(space.Trim()))
                Console.WriteLine("Invalid message2");
            if (String.IsNullOrWhiteSpace(space))
                Console.WriteLine("Invalid message3");

            // convert to numbers
            var input = "25";
            var number = Convert.ToInt32(input);
            number = int.Parse(input);
            Console.WriteLine(number.GetType());

            // convert to string
            var price = 25.58f;
            var str = price.ToString("C0");
            Console.WriteLine(str);
        }
    }
}
