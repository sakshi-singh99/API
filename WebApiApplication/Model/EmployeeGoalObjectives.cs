
using Microsoft.EntityFrameworkCore;

namespace WebApiApplication.viewModel
{
    [Keyless]
    public class EmployeeGoalObjectives
    {
        public string EmployeeQuarterlyGoalName { set; get; }
        public string Objective { set; get; }
        public string Description { set; get; }
        public string Review { set; get; }
        public int CompletedPercentage { set; get; }
        public string ActionStatus { set; get; }
    }
}
