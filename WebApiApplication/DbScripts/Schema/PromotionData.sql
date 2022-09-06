CREATE TABLE PromotionData(
    Employeeid UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES EMPLOYEES(Employeeid),
    LastPromotionDate datetime NOT NULL,
    ReadyForPromotion BIT NOT NULL,
    PromotionComment VARCHAR(50) NOT NULL
)