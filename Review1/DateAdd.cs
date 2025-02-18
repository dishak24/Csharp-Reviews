using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
{
    internal class DateAdd
    {
        public static void DateAddSubtract()
        {
            DateTime currentDate = DateTime.Now;

            DateTime addDays = currentDate.AddDays(30);
            
            DateTime subtractMonths = currentDate.AddMonths(-6);

            DateTime addYear = currentDate.AddYears(1);

            Console.WriteLine("Current Date: " + currentDate);
            Console.WriteLine("After adding 30 days : " + addDays.ToString("yyyy-MM-dd"));
            Console.WriteLine("After subtracting 6 months: " + subtractMonths.ToString("yyyy-MM-dd"));
            Console.WriteLine("After adding 1 year: " + addYear.ToString("yyyy-MM-dd"));
        }

    }
}
