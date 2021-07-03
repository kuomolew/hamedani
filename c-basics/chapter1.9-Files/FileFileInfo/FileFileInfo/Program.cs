using System;
using System.IO;

namespace FileFileInfo
{
    class Program
    {
        static void Main()
        {
            var path = @"c:\temp\myfile1.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);

            if (File.Exists(path))
                File.Delete(path);

            File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"d:\temp\myfile.jpg", true);
            if (fileInfo.Exists)
                fileInfo.Delete();

            
        }

    }
}
