using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review4
{
    internal class DataValidation
    {
        Data data = new Data();

        public void Validate()
        {
            Console.WriteLine("Enter the Data: ");
            Console.WriteLine("Email :");
            data.Email = Console.ReadLine();
            Console.WriteLine("Password :");
            data.Password = Console.ReadLine();
            
            Console.WriteLine();

            

            var contex = new ValidationContext(data);
            var result = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(data, contex, result, true);

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

        
    }
}
