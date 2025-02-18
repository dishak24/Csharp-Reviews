using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
{
    internal interface IPayable
    {
        void GetSalary();
    }

    public class FullTimeEmployee : IPayable
    {
        private double salary;
        public void GetSalary()
        {
            Console.WriteLine("Enter your Salary : ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Full time Employee salary = " +salary);
            Console.WriteLine();

        }


    }

    public class ContractEmployee : IPayable
    {
        private int salaryPerHours;
        private int totalWorkingHours;

        public void GetSalary()
        {
            Console.WriteLine("Enter your Salary per Hours : ");
            salaryPerHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your total working Hours in month : ");
            totalWorkingHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            int totalSalary = salaryPerHours * totalWorkingHours;

            
            Console.WriteLine("Contract Employee salary = " + totalSalary);

        }
    }
}
