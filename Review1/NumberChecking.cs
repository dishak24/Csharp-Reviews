using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
{
    internal class NumberChecking
    {
        public static void MinMaxCheck()
        {
            Console.WriteLine("Enter the 2 Values to check Min and Max : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int num2 = Convert.ToInt32(Console.ReadLine());

            if ( num2 == num1)
            {
                Console.WriteLine("Both are Equal !");
            }

            if ( num1 > num2 )
            {
                Console.WriteLine(num1 + " is Larger than " +num2);
            }
            else
            {
                Console.WriteLine(num2 + " is Smaller than " + num1);
            }

        }
    }
}
