using Microsoft.EntityFrameworkCore;

namespace WebApiApplication.viewModel
{
    [Keyless]
    public class QuarterFinancialYear
    {
        public string FinancialYearName { set; get; }
        public string QuarterFinancialYearName { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
    }
}
