using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    internal class NumberTransformation
    {
        List<int> list = new List<int>() {1, 5, 10, 11, 22, 33, 44, 55};

        public void MultiplyListElements()
        {
            var result = list.Select(ele => ele * 2).ToList();
            Console.WriteLine(" Original List : " );
            result.ForEach(ele => Console.Write(ele + " "));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("After Each element in list multiply by 2: ");
            result.ForEach(ele => Console.Write(ele + " "));
            Console.WriteLine();
            Console.WriteLine();
        }

        public void RemoveElementLessThan10()
        {
            var result = list.RemoveAll(ele => ele < 10);
            Console.WriteLine("List after removing elements < 10 : ");
            foreach( var ele in list )
            {
                Console.Write(ele + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
