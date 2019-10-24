using System;
namespace FileOperations
{
    public class FileInfo
    {
        public FileInfo()
        {
            Directory = null;
            File = null;
        }

        public string Directory { get; set; }
        public string File { get; set; }
    }
}
