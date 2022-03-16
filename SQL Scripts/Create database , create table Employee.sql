CREATE DATABASE WEBAPI_DB
GO

USE WEBAPI_DB
GO

CREATE TABLE Employees
(
     ID int primary key identity,
     FirstName nvarchar(50),
     LastName nvarchar(50),
     Gender nvarchar(50),
     Salary int not null
)
GO

INSERT INTO Employees VALUES ('Pranaya', 'Rout', 'Male', 60000)
INSERT INTO Employees VALUES ('Anurag', 'Mohanty', 'Male', 45000)
INSERT INTO Employees VALUES ('Preety', 'Tiwari', 'Female', 45000)
INSERT INTO Employees VALUES ('Sambit', 'Mohanty', 'Male', 70000)
INSERT INTO Employees VALUES ('Shushanta', 'Jena', 'Male', 45000)
INSERT INTO Employees VALUES ('Priyanka', 'Dewangan', 'Female', 30000)
INSERT INTO Employees VALUES ('Sandeep', 'Kiran', 'Male', 45000)
INSERT INTO Employees VALUES('Shudhansshu', 'Nayak', 'Male', 30000)
INSERT INTO Employees VALUES ('Hina', 'Sharma', 'Female', 35000)
INSERT INTO Employees VALUES ('Preetiranjan', 'Sahoo', 'Male', 80000)
GO