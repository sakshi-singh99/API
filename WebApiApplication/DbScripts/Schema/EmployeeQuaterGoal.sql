CREATE TABLE EmployeeQuaterGoal(
    QuaterName VARCHAR(50),
    GoalName VARCHAR(50) NOT NULL,
    Employeeid UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES EMPLOYEES(Employeeid),
    Weightage int,
)