# ODataSampleControllers

Create tables:

Create Table Employee(
Id INT IDENTITY(1,1) NOT NULL,
FirstName VARCHAR(200) NULL,
LastName VARCHAR(200) NULL,
Salary Decimal(18,2) NULL,
JobRole VARCHAR(50) NULL
CONSTRAINT PK_Employee PRIMARY KEY (Id)
)

Create Table EmployeeAddresses(
Id int IDENTITY (1,1) NOT NULL,
HouseNumber VARCHAR(100),
City VARCHAR(100),
State VARCHAR(100),
Country varchar(100),
EmployeeId int NOT NULL
CONSTRAINT PK_Employee_Addresses_Id PRIMARY KEY (Id)
CONSTRAINT FK_Employee_Addresses_EmployeeId FOREIGN KEY (EmployeeId)
REFERENCES Employee (Id)
)
