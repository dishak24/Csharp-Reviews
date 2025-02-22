using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
     internal class EvenOddUsingLambda
    {
        public void EvenOddChecking()
        {        
            var Check = (int num) => num % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine("Enter any number for checking number even or odd");
            Console.WriteLine( Check(Convert.ToInt32(Console.ReadLine())) );
        }
    }
}
