using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review5
{
    internal class PrimeChecking
    {
        public static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;

            }

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }


            return true;
        }


        public static void CheckPrimeNumber()
        {
            try
            {
                Console.WriteLine("Enter number to check prime or not ");
                int num = Convert.ToInt32(Console.ReadLine());

                if(IsPrime(num))
                {
                    Console.WriteLine($"{num} is prime.");
                }
                else
                {
                    Console.WriteLine($"{num} is not prime !");
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
