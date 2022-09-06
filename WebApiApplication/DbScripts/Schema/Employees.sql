CREATE TABLE EMPLOYEES(
EmployeeId  UNIQUEIDENTIFIER PRIMARY KEY default NEWID(),
Name VARCHAR(50) NOT NULL,
Designation VARCHAR(50) NOT NULL,
SupervisorName VARCHAR(50) NOT NULL,
Department VARCHAR(50) NOT NULL,
Contact int NOT NULL,
JoiningDate DateTime NOT NULL
);

insert into EMPLOYEES values(default,'Durgarao','Trainee','Kalyan','DotNet',99084,13/10/2021)
insert into EMPLOYEES values(default,'Ramarao','Trainee','Kalyan','DotNet',99084,13/10/2021)

select * from EMPLOYEES;