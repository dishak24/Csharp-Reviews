using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review5
{
    internal class NameSorting
    {
        public static void Sort(List<string> name)
        {
            for ( int i = 0; i < name.Count - 1; i++ )
            {
                for (int j = 0; j < name.Count - i - 1; j++)
                {
                    if (name[j].CompareTo(name[j+1]) > 0)
                    {
                        string temp = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortNames()
        {
            List<string> nameList = new List<string>()
            {
                "Disha",
                "Atharv",
                "Riya",
                "Pooja",
                "Priyanka"
            };

            Console.WriteLine("Before Sorting List :");
            foreach( var name in  nameList)
            {
                Console.Write(name + " ");
            }

            Sort(nameList);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("After Sorting List:");
            foreach (var name in nameList)
            {
                Console.Write(name + " ");
            }
        }
    }
}
