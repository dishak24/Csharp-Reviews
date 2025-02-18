using System;

namespace Review1
{
    internal class DateDifference
    {
        public static void CalculateDateDifference()
        {
            Console.Write("Enter two date in the format of yyyy-MM-dd : ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();

            DateTime date2 = DateTime.Parse(Console.ReadLine());

            if (date1 == date2)
            {
                Console.WriteLine("No difference !");
            }

            if (date1 > date2)
            {
                DateTime temp = date1;
                date1 = date2;
                date2 = temp;
            }

            int years = date2.Year - date1.Year;
            int months = date2.Month - date1.Month;
            int days = date2.Day - date1.Day;

            Console.WriteLine("Difference = " + years +" Years "+ months +" Months "+ days + " Days");
        }
    }

}

