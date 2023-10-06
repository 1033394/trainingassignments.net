create database assignment2
use assignment2;
create table employee(
    empno INT primary key,
	ename varchar(50),
	job varchar(50),
	mgr_id INT,
	hiredate date,
	sal FLOAT(7) check (sal>0),
	comm INT,
	deptno INT 
);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7369,'smith','clerk',7902,'17-Dec-80',800,null,20);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7499,'allen','salesman',7698,'20-feb-81',1600,300,30);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7521,'ward','salesman',7698,'22-feb-81',1250,500,30);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7566,'jones','manager',7839,'02-apr-81',2975,null,20);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7354,'martin','salesman',7698,'28-sep-81',1250,1400,30);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7698,'blake','manager',7839,'01-may-81',2850,null,30);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7782,'clark','manager',7839,'09-jun-81',2450,null,10);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7788,'scott','analyst',7566,'19-apr-87',3000,null,20);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7839,'king','president',null,'17-nov-81',5000,null,10);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7844,'turner','salesman',7698,'08-sep-81',1500,0,30);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7876,'adams','clerk',7788,'23-may-87',1100,null,20);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7900,'james','clerk',7698,'03-Dec-81',950,null,30);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7902,'ford','analyst',7566,'03-Dec-81',3000,null,20);
insert into employee(empno,ename,job,mgr_id,hiredate,sal,comm,deptno)
values(7934,'miller','clerk',7782,'23-jan-82',1300,null,10);

create table department(
    deptno INT primary key,
	dname varchar(50),
	loc varchar(50)
);
insert into department values(10,'Accounting','new york'),
(20,'research','dallas'),
(30,'sales','chicago'),
(40,'operations','boston')

/*1. List all employees whose name begins with 'A'. */
SELECT*FROM employee WHERE ename LIKE 'A%';
/*2. Select all those employees who don't have a manager. */
SELECT*FROM employee WHERE mgr_id is null;
/*3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. */
SELECT ename,empno,sal FROM employee WHERE sal BETWEEN 1200 AND 1400;
/*4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.*/
UPDATE employee SET sal=sal*1.1 WHERE deptno=20;
SELECT*FROM employee WHERE deptno =20;
/*5. Find the number of CLERKS employed. Give it a descriptive heading. */
SELECT COUNT(*) AS "number of CLERKS" FROM employee WHERE job='CLERK';
/*6. Find the average salary for each job type and the number of people employed in each job.*/
SELECT job,AVG(sal) AS "AVEARGE SALARY",COUNT(*) AS "number of employees" FROM employee GROUP BY job;
/*7. List the employees with the lowest and highest salary.*/
SELECT *FROM employee WHERE sal=(SELECT MIN(sal) FROM employee)
SELECT *FROM employee WHERE sal=(SELECT MAX(sal) FROM employee)
/*8. List full details of departments that don't have any employees. */
SELECT deptno,dname,loc FROM department WHERE deptno NOT IN(SELECT DISTINCT  deptno FROM employee);
/*9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. */
SELECT ename,sal FROM employee WHERE job='Analyst' AND sal>1200 AND deptno=20  ORDER BY ename ASC;
/*10. For each department, list its name and number together with the total salary paid to employees in that department. */
SELECT d.dname,d.deptno,SUM(E.SAL) AS "total salary"
FROM department d
LEFT JOIN employee e ON d.deptno=e.deptno
GROUP BY d.deptno,d.dname;
/*11. Find out salary of both MILLER and SMITH.*/
SELECT ename,sal FROM employee WHERE ename IN ('MILLER','SMITH');
/*12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. */
SELECT ename FROM  employee WHERE ename LIKE 'A%' OR ename LIKE 'M%';
/*13. Compute yearly salary of SMITH. */
SELECT ename,sal*12 AS "yearly salary" FROM  employee WHERE ENAME='smith';
/*14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.*/
SELECT ename,sal FROM employee WHERE sal NOT BETWEEN 1500 AND 2850;
/*15. Find all managers who have more than 2 employees reporting to them*/
SELECT e.ename,e.mgr_id
FROM employee e
JOIN(SELECT mgr_id,count(*) AS numemployees FROM employee GROUP BY mgr_id)m
ON e.empno=m.mgr_id
WHERE m.numemployees>2;

