using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApiApplication.viewModel
{
    public class EmployeeQuarterlyGoals
    {
        public string QuarterName { set; get; }
        public string GoalName { set; get; }
        [Key]
        public Guid EmployeeId { set; get; }
        public int Weightage { set; get; }
    }
}
