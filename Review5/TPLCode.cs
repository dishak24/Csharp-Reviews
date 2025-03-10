using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review5
{
    internal class TPLCode
    {
        public static async Task WritingInFile(string path)
        {
            List<string> numberList = new List<string>()
            {
                "10", "20", "30", "40", "50", "60", "70", "80", "90", "100"
            };

            await File.WriteAllLinesAsync( path, numberList);

            Console.WriteLine("Numbers are written to the file successfully !! ");
        }

        public static void CalculateSum(int[] array)
        {
            
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            Console.WriteLine($"Total sum of array is {sum} ");
        }

        public static void SortString(List<string> names)
        {
            for (int i = 0; i < names.Count - 1; i++)
            {
                for (int j = 0; j < names.Count - i - 1; j++)
                {
                    if (string.Compare(names[j], names[j + 1]) > 0)
                    {
                        
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("After sorting String: ");
            foreach( var result in names)
            {
                Console.WriteLine(result);
            }
            
        }

        public static async Task PerformTPL()
        {
            string filePath = @"E:\BL\Training\C#\ReviewsCode\Review5\TextFile1.txt";
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            List<string> nameList = new List<string>()
            {
                "Disha",
                "Atharv",
                "Riya",
                "Pooja",
                "Priyanka"
            };

            Task fileTask = WritingInFile(filePath);
            Task sumTask = Task.Run( () => CalculateSum(array) );
            Task sortingTask = Task.Run( () => SortString(nameList));

            await Task.WhenAll(fileTask, sumTask, sortingTask);

        }
    }
}
