using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPIApplication.IServices;
using CoreAPIApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPIApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet]
        //[Route("[action]")]
        [Route("GetEmployee")]
        public IEnumerable<Employee> GetEmployee()
        {

            return this._employeeService.GetEmployee();
        }

        [HttpPost]
        //[Route("Action")]
        [Route("AddEmployee")]
        public Employee AddEmployee(Employee employee)
        {
            return this._employeeService.AddEmployee(employee);
        }

        [HttpPut]
        //[Route("Action")]
        [Route("EditEmployee")]
        public Employee EditEmployee(Employee employee)
        {
            return this._employeeService.UpdatEmployee(employee);
        }

        [HttpDelete]
        //[Route("Action")]
        [Route("DeleteEmployee")]
        public Employee DeleteEmployee(int id)
        {
            return this._employeeService.DeleteEmployee(id);
        }

        [HttpGet]
        //[Route("Action")]
        [Route("GetEmployeeId")]
        public Employee GetEmployeeById(int id)
        {
            return this._employeeService.GetEmployeeById(id);
        }
    }
}