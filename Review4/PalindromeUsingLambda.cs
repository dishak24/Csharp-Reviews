using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    internal class PalindromeUsingLambda
    {
        public static void IsPalindromString()
        {
            Console.WriteLine("Enter any word to check palindrome or not ? ");

            var palindrome = (string str) =>  ( str.ToLower() ) == (new string(str.ToLower().Reverse().ToArray()));

            if(palindrome(Console.ReadLine()))
            {
                Console.WriteLine("Yes, Plaindrome.");
            }
            else
            {
                Console.WriteLine("Not, Palindrome !!");
            }
        }
    }
}
