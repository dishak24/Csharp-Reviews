using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    public class StringPalindromeTesting
    {
        public bool PalindromString(string name)
        {
            char[] arr = name.ToCharArray();
            string result = "";
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                result += arr[i];
            }

            if(name.Equals(result))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
