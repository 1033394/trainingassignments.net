create database exam;
go
use exam;
go

CREATE TABLE Employee(

    empno INT PRIMARY KEY,

    empname VARCHAR(35) NOT NULL,

    empsal NUMERIC(10,2) CHECK (empsal > 25000),

    emptype CHAR(1) CHECK (emptype IN ('F', 'P'))

);
go

 

CREATE PROCEDURE AddEmployee

    @empname VARCHAR(35),

    @empsal NUMERIC(10,2),

    @emptype CHAR(1)

AS

BEGIN

    DECLARE @empno INT;

 

    SELECT @empno = ISNULL(MAX(empno), 0) + 1 FROM Employee;

 

    INSERT INTO  Employee(empno, empname, empsal, emptype)

    VALUES (@empno, @empname, @empsal, @emptype);

 

    SELECT @empno AS EmpNo;

END;
EXEC AddEmployee 'John Doe', 30000, 'F';