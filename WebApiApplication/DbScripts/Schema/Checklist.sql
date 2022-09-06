CREATE TABLE Checklist(
    Employeeid UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES EMPLOYEES(Employeeid),
    QuaterYear VARCHAR(50) NOT NULL,
    CType DateTime(50) NOT NULL,
    Achievable int NOT NULL,
    Achieved int NOT NULL
)