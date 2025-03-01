using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review4
{
    internal class PhoneNumberExtract
    {
        public static MatchCollection Extract(string sentence)
        {
            string pattern = @"\b\d{10}\b";
            return Regex.Matches(sentence, pattern);

        }
        public static void ExtractNumber()
        {
            Console.WriteLine("Enter any String to extract phone number :");
            string sentence = Console.ReadLine();

            MatchCollection match = Extract(sentence);
            Console.WriteLine("Extracted phone Numbers are : ");
            foreach( Match phone in match)
            {
                Console.WriteLine(phone.Value);
            }
        }
    }
}
