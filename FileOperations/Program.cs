using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileCreate();
           
        }
        public static void FileCreate() 
        {
            string path = ("C:/Users/LENOVO/source/repos/FileOperations/FileOperations/abc.txt");
            FileStream obj = new FileStream(path, FileMode.Create);
          {
              Console.WriteLine("File is created");
              obj.Close();
          }
             Console.ReadLine();
        }
    }
}

