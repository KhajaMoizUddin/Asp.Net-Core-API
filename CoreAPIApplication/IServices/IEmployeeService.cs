using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPIApplication.Models;

namespace CoreAPIApplication.IServices
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployee();
        Employee GetEmployeeById(int id);
        Employee AddEmployee(Employee employee);
        Employee UpdatEmployee(Employee employee);
        Employee DeleteEmployee(int id);

    }
}
