using Microsoft.EntityFrameworkCore;

namespace WebApiApplication.viewModel
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext()
        {
        }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<AppraisalDetails> AppraisalDetails { get; set; }
        public DbSet<CheckList> checkLists { get; set; }
        public DbSet<EmployeeGoalMonthWise> EmployeeGoalMonthWise { get; set; }
        public DbSet<EmployeeGoalObjectives> EmployeeGoalObjectives { get; set; }
        public DbSet<EmployeeQuarterlyGoals> EmployeeQuarterlyGoals { get; set; }
        public DbSet<FinancialYear> financialYears { get; set; }
        public DbSet<Goals> Goals { get; set; }
        public DbSet<NineGridDetails> NineGridDetails { get; set; }
        public DbSet<OnTheMoment> OnTheMoment { get; set; }
        public DbSet<PromotionData> PromotionData { get; set; }
        public DbSet<QuarterDetails> QuarterDetails { get; set; }
        public DbSet<QuarterFinancialYear> QuarterFinancialYear { get; set; }
    }
}
