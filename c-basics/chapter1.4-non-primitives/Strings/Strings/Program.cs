using System;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            var firstName = "John";
            var lastName = "Snow";

            var fullName = "1My name is " + firstName + " " + lastName;
            var myFullName = string.Format("2My name is {0} {1}", firstName, lastName);
            var anotherFullName = $"3My name is {firstName} {lastName}";

            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);
            Console.WriteLine(anotherFullName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            // verbatim strings
            var text = "Hi John \nLook into the following paths \nC:\\folder1\\folder2\\folder3";
            var verbatimText = @"Hi John 
Look into the following paths
C:\folder1\folder2\folder3";
            Console.WriteLine(text);
            Console.WriteLine(verbatimText);
        }
    }
}
