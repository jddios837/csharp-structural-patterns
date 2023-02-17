using System.Collections.Generic;

namespace DependencyInjectionExample_01
{
    public class EmployeeBL
    {
        private IEmployeeDAL _employeeDal;
        // public EmployeeDAL employeeDAL;

        public EmployeeBL(IEmployeeDAL employeeDal)
        {
            _employeeDal = employeeDal;
        }
        
        public List<Employee> GetAllEmployees()
        {
            return _employeeDal.SelectAllEmployees();
        }
    }
}