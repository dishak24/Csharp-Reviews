using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review5
{
    internal class AgeValidator
    {
        public static void ActualValidate( int age)
        {

            if ( age < 18)
            {
                throw new InvalidAgeException("Age must Greater than 18 !!! ");
            }
            else
            {
                Console.WriteLine("Age is Valid.");
            }              

        }

        public static void ValidateAge()
        {
            try
            {

                Console.WriteLine("Enter your age: ");
                AgeValidator.ActualValidate(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine();

                
            }

            catch(InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            


        }
    }
}
