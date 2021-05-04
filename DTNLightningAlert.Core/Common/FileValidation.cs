using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DTNLightningAlert.Core.Common
{
    public static class FileValidation
    {
        public static string FileChecker(string path)
        {
            while (!IsFileExist(path))
            {
                Console.WriteLine("File not found! Please enter a valid file path: ");
                path = Console.ReadLine().ToString();
            }

            return path;
        }

        private static bool IsFileExist(string path)
        {
            var result = false;

            if (File.Exists(path))
            {
                result = true;
            }

            return result;
        }
    }
}
