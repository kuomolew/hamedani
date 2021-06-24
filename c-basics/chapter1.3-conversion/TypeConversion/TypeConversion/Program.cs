using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1000;
            //byte b = (byte)i;
            //Console.WriteLine(b);

            string number = "1234";
            
            try
            {
                int i = Convert.ToByte(number);
                //int i = int.Parse(number);
                Console.WriteLine(i);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The number can not be converted to a byte.");
            }

            try
            {
                string str = "false";
                int integer = 0;
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
