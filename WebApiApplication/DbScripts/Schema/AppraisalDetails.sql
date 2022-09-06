CREATE TABLE AppraisalDetails(
    Employeeid UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES EMPLOYEES(Employeeid),
    Quateryear DateTime(50) NOT NULL,
    NoOfGoal int,
    NineGridScoreDescription VARCHAR(50) NOT NULL, 
    Reviewer VARCHAR(50) NOT NULL,
    HappinessPercent int NOT NULL,
    Action VARCHAR(50) NOT NULL,
    CompletedPercent int NOT NULL,
    PerformancePercent int NOT NULL,
    ExceptionallyHighPerformer BIT NOT NULL,
    BehaviouralPercent VARCHAR(50) NOT NULL,
    AnyPerfIssueTobeNotifiedToHR VARCHAR(50) NOT NULL,
    ProjectManagerFeedBack VARCHAR(50) NOT NULL,
    CommentsToSupport VARCHAR(50) NOT NULL
    );