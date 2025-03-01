using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review4
{
    internal class DateExtract
    {
        public static MatchCollection Extract(string sentence)
        {
            string pattern = @"\b(\d{2}/\d{2}/\d{4} || \d{4}-\d{2}-\d{2})\b";
            return Regex.Matches(sentence, pattern);

        }
        public static void ExtractDate()
        {
            Console.WriteLine("Enter any String to extract date only :");
            string sentence = Console.ReadLine();

            MatchCollection match = Extract(sentence);
            Console.WriteLine("Extracted Dates : ");
            foreach (Match date in match)
            {
                Console.WriteLine(date.Value);
            }
        }
    }
}
