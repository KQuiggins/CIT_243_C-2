using System;
using static System.Console;
using static System.Console;
using System.IO;
class DirectoryInformation
{
   static void Main()
   {
        const string terminate = "end";
        string directoryName;
        string[] directoryList;
        string[] fileList;
        WriteLine("Enter the name of the directory: ");
        directoryName = ReadLine();
        while (directoryName != terminate)
        {
            if (Directory.Exists(directoryName))
            {
                directoryList = Directory.GetDirectories(directoryName);
                WriteLine("Subdirectories of {0}:", directoryName);
                foreach (string directory in directoryList)
                    WriteLine(directory);
                fileList = Directory.GetFiles(directoryName);
                WriteLine("{0} contains the following files:", directoryName);
                foreach (string file in fileList)
                    WriteLine(file);
            }
            else
                WriteLine("Directory {0} does not exist", directoryName);
            WriteLine("Enter another directory: ");
            directoryName = ReadLine();
        }

       
   }
}

