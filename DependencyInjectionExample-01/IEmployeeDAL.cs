using System.Collections.Generic;

namespace DependencyInjectionExample_01
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}