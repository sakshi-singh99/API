using Microsoft.EntityFrameworkCore;

namespace WebApiApplication.viewModel
{
    [Keyless]
    public class OnTheMoment
    {
        public Guid FromEmployeeNumber { set; get; }
        public Guid ToEmployeeNumber { set; get; }
        public string Comments { set; get; }
        public DateTime RequestedDate { set; get; }
        public DateTime RespondedOn { set; get; }
        public string Action { set; get; }
    }
}
