using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWayCsTraining
{
    class FileHandling
    {
        public static void CreateFile(string fileNamePath)
        {
            //Creating a file
            FileStream stream = File.Create(fileNamePath);

            if (File.Exists(fileNamePath))
                Console.WriteLine("File created successfully");
            else
                Console.WriteLine("File was not created");
        }

        public static void CreateFileSimple()
        {
            File.Create(@"D:\TrainingFiles\Today\newFile.txt");
        }

        public static void OpenFile(string fileNamePath, string textToBeWritten)
        {
            FileStream fs = File.Open(fileNamePath, FileMode.Open);
        }

        public static void WriteToFile(string fileNameWithPath, string content)
        {
            File.WriteAllText(fileNameWithPath, content);
        }

        public static void AppendToFile(string fileNameWithPath, string content)
        {
            File.AppendAllText(fileNameWithPath, content);
        }

        public static string ReadFromFile(string fileNameWithPath)
        {
            return File.ReadAllText(fileNameWithPath);
        }
    }
}
