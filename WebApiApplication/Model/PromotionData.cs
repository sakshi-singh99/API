
using System.ComponentModel.DataAnnotations;

namespace WebApiApplication.viewModel
{
    public class PromotionData
    {
        [Key]
        public Guid EmployeeId { set; get; }
        public DateTime LastPromotionDate { set; get; }
        public string ReadyForPromotion { set; get; }
        public string PromotionComments { set; get; }
    }
}
