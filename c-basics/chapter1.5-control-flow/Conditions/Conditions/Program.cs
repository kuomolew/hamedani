using System;

namespace Conditions
{
    partial class Program
    {
        static void Main()
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning!");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon!");
            }
            else
            {
                Console.WriteLine("Its evening!");
            }

            bool isGoldCustomer = true;
            float price;

            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            var season = Season.Summer;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn");
                    break;
                case Season.Spring:
                case Season.Summer:
                    Console.WriteLine("We've got a promotion!");
                    break;
                default:
                    Console.WriteLine("It's winter");
                    break;
            }
        }
    }
}
