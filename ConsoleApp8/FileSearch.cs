using System;
using System.IO;

namespace ConsoleApp8
{
    class FileSearch
    {
        public static void Search(string text, string path = @"c:\")
        {
            string[] files;
            try
            {
                files = Directory.GetFiles(path);
            }
            catch (UnauthorizedAccessException e)
            {
                return;
            }
            
            foreach (var file in files)
            {
                if (file.ToLower().Contains(text.ToLower()))
                {
                    Console.WriteLine(file);
                }
            }

            var directories = Directory.GetDirectories(path);
            foreach (var directory in directories)
            {
                Search(text, directory);
            }
        }
    }
}
