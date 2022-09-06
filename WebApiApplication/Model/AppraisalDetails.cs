using System.ComponentModel.DataAnnotations;

namespace WebApiApplication.viewModel
{
    public class AppraisalDetails
    {
        [Key]
        public Guid EmployeeNumber { set; get; }
        public DateTime QuarterYear { set; get; }
        public  int NumberOfGoals { set; get; }
        public string NineGridScoreDescription { set; get; }
        public string Reviewer { set; get; }
        public string HappinessPercent { set; get; }
        public string Action { set; get; }
        public int CompletedPercent { set; get; }   
        public int PerformancePercent { set; get; }
        public int BehaviouralPercent { set; get; }
        public string ExceptionallyHighPerformer { set; get; }
        public string AnyIssue { set; get; }
        public string ProjectManagerFeedback { set; get; }
        public string CommentsToSupport { set; get; }

    }
}
