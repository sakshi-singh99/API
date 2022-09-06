using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiApplication.Model;
using WebApiApplication.viewModel;

namespace WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public EmployeeDbContext employee = null;
        public EmployeesController(EmployeeDbContext employeeDbContext)
        {
            employee = employeeDbContext;
        }
        //public void Register(Guid id,string name,string designation,string sname, string department, int contact, DateTime date)
        //{
        //    Employees employees = new Employees();
        //    employees.EmployeeId = id;
        //    employees.Name = name;
        //    employees.Designation = designation;
        //    employees.SupervisiorName = sname;
        //    employees.Department = department;
        //    employees.Contact = contact;
        //    employees.JoiningDate = date;
        //    EmployeeRepository employeeRepository = new EmployeeRepository(employee);
        //    employeeRepository.Register(employees);
        //}
        [HttpGet]
        public List<Employees> Get()
        {
            return employee.Employees.ToList();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employees emp)
        {
            employee.Employees.Add(emp);
            employee.SaveChanges();
            return NoContent();
        }
    }
}
