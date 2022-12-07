using Asp.NetCoreWebAPI.Models;
using Asp.NetCoreWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreWebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController(IEmployeeRepository employeeRepository) {
            EmployeeRepository = employeeRepository;
        }

        private readonly IEmployeeRepository EmployeeRepository;
        [HttpGet]
        [Route("Test/Get")]
        public int Index() {
            return 20;
        }

        [HttpGet]
        [Route("Employee/Get")]
        public IEnumerable<Employee> GetEmployees() {
            return EmployeeRepository.GetAllEmployee();
        }

        [HttpGet]
        [Route("Employee/Get/{id}")]
        public Employee GetEmployeeById(int id) {
            return EmployeeRepository.GetEmployee(id);
        }

        [HttpPost]
        [Route("Employee/Post")]
        public Employee AddEmployee(Employee employee) {
            var newemployee= EmployeeRepository.Add(employee);
            return newemployee;
        }

        [HttpDelete]
        [Route("Employee/Delete/{id}")]
        public Employee DeleteEmployee( int id) {
            var deleteemp= EmployeeRepository.Delete(id);
            return deleteemp;
        }
    }
}
