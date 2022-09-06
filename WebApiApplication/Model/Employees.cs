using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApiApplication.viewModel
{
    public class Employees
    {
        [Key]
        public Guid EmployeeId { set; get; }
        public string Name { set; get; }
        public string Designation { set; get; }
        public string SupervisiorName { set; get; }
        public string Department { set; get; }
        public int  Contact { set; get; }
        public DateTime JoiningDate { set; get; }

    }
}
