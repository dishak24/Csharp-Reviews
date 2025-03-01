using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Review4
{
    public class UserRegistrationValidation
    {
        UserRegistration user = new UserRegistration();
        public bool Validate()
        {
            Console.WriteLine("Enter the Data: ");
            Console.WriteLine("Name: ");
            user.Name= Console.ReadLine();
            Console.WriteLine("Email :");
            user.Email = Console.ReadLine();
            Console.WriteLine("Password :");
            user.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();



            var contex = new ValidationContext(user);
            var result = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(user, contex, result, true);

            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }

            

        }
    }
}
