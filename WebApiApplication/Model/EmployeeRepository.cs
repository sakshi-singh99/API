using DocumentFormat.OpenXml.Office2010.Excel;
using WebApiApplication.viewModel;

namespace WebApiApplication.Model
{
    public class EmployeeRepository
    {
        public EmployeeDbContext employee;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            employee = employeeDbContext;
        }
        public void Register(Employees emp)
        {
            
            employee.Employees.Add(emp);
        }
    }
}
