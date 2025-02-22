using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    internal class MaxNumberLambda
    {
        public void FindMaxNumber()
        {
            
            Console.WriteLine("Enter 2 number to compare : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            var Max = (int a, int b) => a > b ? a : b;

           
            Console.WriteLine($"Max number = {Max(num1, num2)}");
        }
    }
}

