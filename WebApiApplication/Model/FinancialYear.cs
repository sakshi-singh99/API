using Microsoft.EntityFrameworkCore;

namespace WebApiApplication.viewModel
{
    [Keyless]
    public class FinancialYear
    {
        public string FinancialYearName { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
    }
}
