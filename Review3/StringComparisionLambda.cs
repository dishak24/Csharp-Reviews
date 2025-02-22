using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    internal class StringComparisionLambda
    {
        public void LengthCompare()
        {
            var Check = (string str1, string str2) => str1.Length.CompareTo(str2.Length);

            Console.WriteLine("Enter 2 words for comparing length : ");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            int result = Check(s1, s2);

            if ( result < 0)
            {
                Console.WriteLine($"{s1} having Minimum Lenth than {s2}");
            }
            else if(result > 0)
            {
                Console.WriteLine($"{s2} having Minimum Lenth than {s1}");
            }
            else
            {
                Console.WriteLine($"{s2} and {s1} having Same Length");
            }
        }
    }
}
