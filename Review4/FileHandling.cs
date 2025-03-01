using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    internal class FileHandling
    {
        string path = @"E:\BL\Training\C#\ReviewsCode\Review4\TextFile1.txt";
        public void ReadFile()
        {            
            
            if (File.Exists(path))
            {
                string readData = File.ReadAllText(path);
                Console.WriteLine("File Contents : " + readData);
            }
            else
            {
                File.Create(path);
            }
        }

        public void WriteData()
        {
            if (File.Exists(path))
            {
                
                Console.WriteLine("Enter data in files : ");
                //File.WriteAllText(path, Console.ReadLine());
                File.AppendAllText(path, Console.ReadLine());
                Console.WriteLine("Data is over written successfully !! ");
            }

        }
    }
}
