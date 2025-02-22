using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review3
{
    internal class UserDataValidation
    {
        UserData userData = new UserData();

        public void Validate()
        {
            Console.WriteLine("Enter the Data: ");
            Console.WriteLine("Email :");
            userData.Email = Console.ReadLine();
            Console.WriteLine("Password :");
            userData.Password = Console.ReadLine();
            Console.WriteLine("Mobile Number :");
            userData.Mobile = Console.ReadLine();
            Console.WriteLine();

            

            var contex = new ValidationContext(userData);
            var result = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(userData, contex, result, true);

            if (isValid)
            {
                Console.WriteLine("All data is valid.");
            }
            else
            {
                Console.WriteLine("Error: ");
                foreach( var err in result)
                {
                    Console.WriteLine(err.ErrorMessage);
                }
            }

            Console.WriteLine();

        }

        public void FindDuplicate()
        {
            Console.WriteLine("Enter any sentence to find duplicate words :");
            string sentence = userData.DuplicateWords(Console.ReadLine());
            Console.WriteLine();

            string pattern = @"\b(\w+)\s+\1\b";

            MatchCollection match = Regex.Matches(  sentence, pattern, RegexOptions.IgnoreCase);

            Console.WriteLine("Duplicate Words :");
            foreach( Match words in match)
            {
                Console.WriteLine(words.Value);
            }
        }
    }
}
