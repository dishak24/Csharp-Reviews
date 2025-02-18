using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
{
    internal class DiceNumber
    {
        Random r = new Random();

        public void RollDice()
        {
            Console.WriteLine("Roll the 6-Sides Dies: ");

            int number = r.Next(1,7);

            Console.WriteLine("You got a "+number+ " !");
        }
    }
}
