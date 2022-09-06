using Microsoft.EntityFrameworkCore;

namespace WebApiApplication.viewModel
{
    [Keyless]
    public class Goals
    {
        public string GoalName { set; get; }
        public string GoalType { set; get; }
    }
}
