create database employee;
go
use employee;
go
create  table employee(
   employeeid int primary key,
   name varchar(100),
   salary decimal(10,2)
   );
go
insert into employee(employeeid,name,salary)
values(1,'teju',50000.00);
go
CREATE PROCEDURE GeneratePayslip (@EmployeeID INT)

AS

BEGIN

    DECLARE @EmployeeName NVARCHAR(100)

    DECLARE @Salary DECIMAL(10, 2)

    DECLARE @HRA DECIMAL(10, 2)

    DECLARE @DA DECIMAL(10, 2)

    DECLARE @PFPercentage DECIMAL(5, 2)

    DECLARE @ITPercentage DECIMAL(5, 2)

    DECLARE @Deductions DECIMAL(10, 2)

    DECLARE @GrossSalary DECIMAL(10, 2)

    DECLARE @NetSalary DECIMAL(10, 2)

 

    -- Retrieve employee information

    SELECT @EmployeeName = Name, @Salary = Salary

    FROM Employee

    WHERE EmployeeID = @EmployeeID

 

    -- Calculate HRA

    SET @HRA = 0.10 * @Salary

 

    -- Calculate DA

    SET @DA = 0.20 * @Salary

 

    -- Calculate PF (8% of salary)

    SET @PFPercentage = 8.0

    SET @PFPercentage = (@PFPercentage / 100) * @Salary

 

    -- Calculate IT (5% of salary)

    SET @ITPercentage = 5.0

    SET @ITPercentage = (@ITPercentage / 100) * @Salary

 

    -- Calculate Deductions (sum of PF and IT)

    SET @Deductions = @PFPercentage + @ITPercentage

 

    -- Calculate Gross Salary

    SET @GrossSalary = @Salary + @HRA + @DA

 

    -- Calculate Net Salary

    SET @NetSalary = @GrossSalary - @Deductions

 

    -- Output the payslip

    PRINT 'Payslip for Employee: ' + @EmployeeName

    PRINT '-------------------------------'

    PRINT 'Basic Salary: ' + CAST(@Salary AS NVARCHAR(100))

    PRINT 'HRA: ' + CAST(@HRA AS NVARCHAR(100))

    PRINT 'DA: ' + CAST(@DA AS NVARCHAR(100))

    PRINT 'pfpercentage: ' + CAST(@pfpercentage AS NVARCHAR(100))

    PRINT 'ITPercentage: ' + CAST(@ITPercentage AS NVARCHAR(100)) 

    PRINT 'Deductions: ' + CAST(@Deductions AS NVARCHAR(100)) 

    PRINT 'Gross Salary: ' + CAST(@GrossSalary AS NVARCHAR(100))

    PRINT 'Net Salary: ' + CAST(@NetSalary AS NVARCHAR(100))

END
go
exec GeneratePayslip @employeeid=1;