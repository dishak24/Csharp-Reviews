using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    internal class DivideException
    {
        public void NumberDivision()
        {
            try
            {
                Console.WriteLine("Enthe Number-1 ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enthe Number-2 ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine($"Result = {result}");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }

            catch(FormatException e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
