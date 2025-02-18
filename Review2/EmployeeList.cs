using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Review2
{
    internal class EmployeeList
    {
        List<Employee> empList = new List<Employee>
        {
            new Employee { Id = 1, Name = "Disha" },
            new Employee { Id = 2, Name = "Riya" },
            new Employee { Id = 3, Name = "Pratibha" },
            new Employee { Id = 4, Name = "Atharv" }

        };

        public void AddEmployee()
        {
           empList.Add(new Employee { Id = 5, Name = "Asmita" });
            Console.WriteLine("Added Successfully !");
            Console.WriteLine();
        }

        public void RemoveEmployee()
        {
            empList.RemoveAll( emp => emp.Id == 2);
            Console.WriteLine("Data removed!");
            Console.WriteLine();
        }

        public void SearchEmployee()
        {
            var searchEmp = empList.Find(emp => emp.Name == "Disha");
            Console.WriteLine($"{searchEmp.Name} : Employee Found.. ");
            Console.WriteLine();
        }

        public void DisplayList()
        {
            empList.ForEach(emp => Console.WriteLine($" Id: {emp.Id} Name: {emp.Name}"));
            Console.WriteLine();
        }
            
    }
}
