using Classes.Math;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            var person = new Person();
            person.FirstName = "John";
            person.LastName = "Smith";
            person.Introduce();

            var result = Calculator.Add(1, 2);
            System.Console.WriteLine(result);
        }
    }
}
