﻿namespace _3._Extract_File
{
    internal class Program
    {
        static void Main()
        {
            string filePath = Console.ReadLine();

            string fileName = string.Empty;
            string fileExtention = string.Empty;

            int lastSeparatorIndex = filePath.LastIndexOf('\\');
            int extensionIndex = filePath.LastIndexOf('.');

            if (lastSeparatorIndex != -1 && extensionIndex != -1 && extensionIndex > lastSeparatorIndex)
            {
                fileName = filePath.Substring(lastSeparatorIndex + 1,extensionIndex - lastSeparatorIndex - 1);
                fileExtention = filePath.Substring(extensionIndex + 1);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtention}");
        }
    }
}