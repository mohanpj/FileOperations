using System;
namespace FileOperations
{
    public class FileHelper
    {
        public FileHelper()
        {
        }

        public FileInfo SplitDirectoryFile(string path)
        {
            FileInfo fileInfo = new FileInfo();
            
            // assumes a validated full path
            if (path != null)
            {
                int length = path.Length;
                int rootLength = GetRootLength(path);

                // ignore a trailing slash
                if (length > rootLength && EndsInDirectorySeparator(path))
                    length--;

                // find the pivot index between end of string and root
                for (int pivot = length - 1; pivot >= rootLength; pivot--)
                {
                    if (IsDirectorySeparator(path[pivot]))
                    {
                        fileInfo.Directory = path.Substring(0, pivot);
                        fileInfo.File = path.Substring(pivot + 1, length - pivot - 1);
                    }
                }

                // no pivot, return just the trimmed directory
                fileInfo.Directory = path.Substring(0, length);
            }
            return fileInfo;
        }

        private bool EndsInDirectorySeparator(string path)
        {
            return true;
        }

        private bool IsDirectorySeparator(char value)
        {
            return true;
        }

        private int GetRootLength(string path)
        {
            return path.Length;
        }
    }
}
