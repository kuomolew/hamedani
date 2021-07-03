using System;
using System.IO;

namespace Path
{
    class Program
    {
        static void Main()
        {
            var path = @"c:\temp\myfile.jpg";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            extension = System.IO.Path.GetExtension(path);
            var fileName = System.IO.Path.GetFileName(path);
            var fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(path);
            var directoryName = System.IO.Path.GetDirectoryName(path);

            Console.WriteLine(extension);
            Console.WriteLine(fileName);
            Console.WriteLine(fileNameWithoutExtension);
            Console.WriteLine(directoryName);


        }
    }
}
