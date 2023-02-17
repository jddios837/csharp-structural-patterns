using System;
using System.Collections.Generic;

namespace DependencyInjectionExample_01
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBL employeeBl = new EmployeeBL(new EmployeeDAL());
            List<Employee> list = employeeBl.GetAllEmployees();

            foreach (var emp in list)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
        }
    }
}