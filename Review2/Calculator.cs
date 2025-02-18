using System;
using System.Collections.Generic;
using System.Text;

namespace Review2
{
   public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add( int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, int b)
        {
            return a + b;
        }

        public void DisplayOverloding()
        {
            int sum1 = Add(20, 10);
            int sum2 = Add(10, 20, 30);
            double sum3 = Add(2.2 ,2);

            Console.WriteLine($"Add(int a, int b) = {sum1}");
            Console.WriteLine($"Add( int a, int b, int c) = {sum2}");
            Console.WriteLine($"Add(double a, int b) = {sum3}");
            Console.WriteLine();
        }

    }
}
