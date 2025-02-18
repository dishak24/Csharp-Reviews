using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Channels;

namespace Review2
{
    public class ArrayMaxValue
    {

        public T FindMaxValue<T>(T[] array) where T : IComparable<T>
        {
            T max = array[0];
            foreach ( T ele in array)
            {
                if ( max.CompareTo(ele) < 0 )
                {
                    max = ele;
                }
            }

            return max;

        }

        public void DisplayMaxValue()
        {
            int[] intArray = new int[] {20, 10, 60, 30, 40,50 };
            float[] floatArray = new float[] { 2.2f, 1.09f, 6.10f, 9.30f, 40.7f, 5.0f };

            int intMax = FindMaxValue(intArray);
            float floatMax = FindMaxValue(floatArray);

            Console.WriteLine($"{intMax} is the max element in integer array");
            Console.WriteLine();
            Console.WriteLine($"{floatMax} is the max element in float array");
            Console.WriteLine();
        }
    }
}
