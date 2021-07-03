using System;
using System.IO;

namespace Directory
{
    class Program
    {
        static void Main()
        {
            System.IO.Directory.CreateDirectory(@"c:\temp\folder1");
            var files = System.IO.Directory.GetFiles(@"c:\temp", "*.*", SearchOption.AllDirectories);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }

            
            if (System.IO.Directory.Exists(@"c:\temp"))
            {
                var directories = System.IO.Directory.GetDirectories(@"c:\temp", "*.*", SearchOption.AllDirectories);
                foreach (var directory in directories)
                    Console.WriteLine(directory); 
            }
        }
    }
}
