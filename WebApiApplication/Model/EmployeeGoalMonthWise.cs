using Microsoft.EntityFrameworkCore;

namespace WebApiApplication.viewModel
{
    [Keyless]
    public class EmployeeGoalMonthWise
    {
        
        public string EmployeeGoalObjective {set; get;}
        public string quarterName { set; get;}
        public string EmployeeComments { set; get;}
        public string SupervisorComments { set; get;}
        public int CompletedPercent { set; get; }
    }
}
