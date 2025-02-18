using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
{
    internal class ArmstrongNumber
    {
        public static void Armstrong()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int originalNumber = num;
            int digitsLength = num.ToString().Length;

            while (originalNumber > 0)
            {
                int digit = originalNumber % 10;
                sum += (int)Math.Pow(digit, digitsLength);
                originalNumber /= 10;
            }

            if (sum == num)
            {
                Console.WriteLine("Yes! "+num +" is an Armstrong number.");
            }
                
            else
                Console.WriteLine("No! "+num + " is not an Armstrong number.");

            
        }

    }

}

