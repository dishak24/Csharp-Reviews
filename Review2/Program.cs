using System;

namespace Review2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 2nd Review ");
            Console.WriteLine();

            ArrayMaxValue arrayMaxValue = new ArrayMaxValue();
            arrayMaxValue.DisplayMaxValue();

            Calculator methodOverloading = new Calculator();
            methodOverloading.DisplayOverloding();

            MethodOverriding methodOverriding = new MethodOverriding();
            methodOverriding.Display();

            Child child = new Child();
            child.Display();

            EmployeeList employeeList = new EmployeeList();
            employeeList.AddEmployee();
            employeeList.DisplayList();
            employeeList.RemoveEmployee();
            employeeList.DisplayList();

            StudentList studentList = new StudentList();
            studentList.SortByAge();
            studentList.SortByName();






        }
    }
}
