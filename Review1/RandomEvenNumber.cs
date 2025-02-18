using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
{
    internal class RandomEvenNumber
    {
        Random r = new Random();

        public void EvenNumber()
        {
            int number = r.Next(5,26) ;

            Console.WriteLine("random Even number between 10-50 is : " + number * 2 );

        }
    }
}
