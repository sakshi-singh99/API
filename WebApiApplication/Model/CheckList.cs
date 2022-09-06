using System.ComponentModel.DataAnnotations;

namespace WebApiApplication.viewModel
{
    public class CheckList
    {
        [Key]
        public Guid EmployeeId { set; get; }
        public DateTime QuarterYear { set; get; }
        public string CType { set; get; }    
        public int Achievable { set; get; }
        public int Achieved { set; get; }
    }
}
