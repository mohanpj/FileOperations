using System;

namespace FileOperations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fileHelper = new FileHelper();
            fileHelper.SplitDirectoryFile("c://somepath/samplefile.txt");
            Console.ReadKey();
        }
    }
}
