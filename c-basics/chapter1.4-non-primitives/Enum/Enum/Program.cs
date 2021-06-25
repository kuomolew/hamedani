using System;

namespace Enum
{
    public enum ShippingMethod
    {
        RegularMail = 1,
        RegisteredMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main()
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)System.Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
