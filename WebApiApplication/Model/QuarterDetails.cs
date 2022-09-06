using Microsoft.EntityFrameworkCore;

namespace WebApiApplication.viewModel
{
    [Keyless]
    public class QuarterDetails
    {
        public string QuarterFinancialYearName { set; get; }
        public int MonthNumber { set; get; }
        public string MonthName { set; get; }
    }
}
