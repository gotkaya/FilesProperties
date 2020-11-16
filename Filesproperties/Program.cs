using System;
using System.IO;

namespace Filesproperties
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);


            foreach(string file in files)
            {
                Console.WriteLine(file);
                var fileData = new FileInfo(file);
                Console.WriteLine(fileData);
                string fileName = fileData.Name;
                string fileDirectory = fileData.DirectoryName;
                long fileSize = fileData.Length;

                Console.WriteLine($"File name :{fileName}; location:{fileDirectory}; Size: {fileSize}");

            }



        }
    }
}
