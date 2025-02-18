using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
{
    internal class ReverseString
    {
        public static void Reverse() 
        {
            Console.WriteLine("Enter any string to reverse :");
            string str = Console.ReadLine();

            Console.WriteLine("Reversed String = " + Reverse(str));
      
        }

        public static string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            string reverseStr = "";

            for (int i = chars.Length-1; i >= 0 ; i--)
            {
                reverseStr += chars[i];
            }

            return reverseStr;

        }


    }
}
