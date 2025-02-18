using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Review2
{
    public class StudentList
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Disha", Age = 23 },
            new Student { Name = "Kittu", Age = 18 },
            new Student { Name = "Riya", Age = 16 },
            new Student { Name = "Ritika", Age = 20 },
            new Student { Name = "Rachit", Age = 22 }
        };

        public void SortByAge()
        {
            Console.WriteLine("Sort by Age: ");
            var sort = students
                       .OrderBy(s => s.Age)
                       .ToList();
            sort.ForEach( s => Console.WriteLine($"Name: {s.Name}, Age: {s.Age}"));
            Console.WriteLine();
            
        }

        public void SortByName()
        {
            Console.WriteLine("Sort by Names: ");
            var sort = students
                       .OrderByDescending(s => s.Name)
                       .ToList();
            sort.ForEach(s => Console.WriteLine($"Name: {s.Name}, Age: {s.Age}"));
            Console.WriteLine();
        }
    }
}
