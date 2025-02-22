using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    internal class AgeValidator
    {
        public static void ActualValidate( int age)
        {

            if ( age < 0 || age > 150)
            {
                throw new CustomAgeException("Age must Greater than 0 and Less than 150 !!! ");
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

                Console.WriteLine("Enter your age (0 -150): ");
                AgeValidator.ActualValidate(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine();

                
            }

            catch(CustomAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            


        }
    }
}
