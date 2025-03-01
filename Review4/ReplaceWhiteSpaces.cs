using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review4
{
    internal class ReplaceWhiteSpaces
    {
        public static void ReplaceSpace()
        {
            Console.WriteLine("Enter any sentence : ");
            string sentence = Console.ReadLine();

            //string result = sentence.Replace(@"\s+", " ").Trim();

            Console.WriteLine("Sentence after removing extra Spaces :");
            Console.WriteLine(Regex.Replace(sentence, @"\s+", " ").Trim());

        }


    }
}
