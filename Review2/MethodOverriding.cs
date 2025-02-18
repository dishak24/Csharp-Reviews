using System;
using System.Collections.Generic;
using System.Text;

namespace Review2
{
    public class MethodOverriding
    {
        public virtual  void Display()
        {
            Console.WriteLine("base class Display() method");
            Console.WriteLine();
        }
    }

    public class Child : MethodOverriding
    {
        public override void Display()
        {

            Console.WriteLine("Child class Display() method");
            Console.WriteLine();
        }
    }
}
