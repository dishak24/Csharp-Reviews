using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
{
    internal class SwapNumber
    {
        private int num1;
        private int num2;

        public void Swap()
        {
            Console.WriteLine("Enter 2 numbers to swap :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Before Swap: ");
            Console.WriteLine("Number 1 = " + num1);
            Console.WriteLine("Number 2 = " + num2);
            Console.WriteLine();

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("after Swap: ");
            Console.WriteLine("Number 1 = " + num1);
            Console.WriteLine("Number 2 = " + num2);

            Console.WriteLine();
            
        }
    }
}
