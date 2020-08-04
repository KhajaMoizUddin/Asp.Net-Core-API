using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPIApplication.IServices;
using CoreAPIApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreAPIApplication.Services
{
    public class EmployeeServices : IEmployeeService
    {
        private APICoreDBContext _dbContext;

        public EmployeeServices(APICoreDBContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            if (employee != null)
            {
                this._dbContext.Employee.Add(employee);
                this._dbContext.SaveChanges();
                return employee;
            }

            return null;
        }

        public Employee DeleteEmployee(int id)
        {
            var employee = this._dbContext.Employee.FirstOrDefault(x => x.Id == id);
            this._dbContext.Employee.Remove(employee);
            //dbContext.Entry(employee).State = EntityState.Deleted;
            this._dbContext.SaveChanges();
            return employee;
        }

        public IEnumerable<Employee> GetEmployee()
        {
            var employees = this._dbContext.Employee.ToList();
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            var employeeById = this._dbContext.Employee.FirstOrDefault(x => x.Id == id);
            return employeeById;
        }

        public Employee UpdatEmployee(Employee employee)
        {
            _dbContext.Entry(employee).State = EntityState.Modified;
            this._dbContext.SaveChanges();
            return employee;
        }
    }
}
