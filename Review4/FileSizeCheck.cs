using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    internal class FileSizeCheck
    {
        public static void SizeChecking( string path)
        {
            long MaxFileSize = 1024 * 5;

            FileInfo fileInfo = new FileInfo(path);
            if(fileInfo.Length > MaxFileSize)
            {
                throw new FileSizeException("File is very large. File must less than 5KB ");
            }

        }

        public static void FileCheck()
        {
            try
            {
                SizeChecking(@"E:\BL\Training\C#\C#DailyUpdate.txt");
            }
            catch(FileSizeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
