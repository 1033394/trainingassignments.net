create database assign3
use assign3;
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
(40,'operations','boston');
/*1. Retrieve a list of MANAGERS. */
select distinct ename
from employee
where job='manager';
/*2. Find out the names and salaries of all employees earning more than 1000 per month. */
select ename,sal
from employee
where sal>1000;
/*3. Display the names and salaries of all employees except JAMES. */
select ename,sal
from employee
where ename <> 'james';
/*4. Find out the details of employees whose names begin with ‘S’. */
select*
from employee
where ename like 's%';
/*5. Find out the names of all employees that have ‘A’ anywhere in their name.*/
select ename
from employee
where ename like '%a%';
/*6. Find out the names of all employees that have ‘L’ as their third character in their name.*/
select ename
from employee
where SUBSTRING(ename,3,1)='l';
/*7. Compute daily salary of JONES. */
select ename,sal/30 as "daily salary"
from employee
where ename='jones';
/*8. Calculate the total monthly salary of all employees. */
select sum(sal) as "total monthly salary"
from employee;
/*9. Print the average annual salary .*/
select avg(sal*12)as "average annual salary"
from employee
/*10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. */
select ename,job,sal,deptno
from employee
where deptno =30 and job<> 'salesman';
/*11. List unique departments of the EMP table. */
select distinct deptno
from employee
/*12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.*/
select ename as "employee",sal as"monthly salary"
from employee
where(deptno=10 or deptno=30) and sal>1500;
/*13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000.*/
select ename,job,sal
from employee
where(job ='manager'or job='analyst') and sal not in(1000,3000,5000);
/*14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. */
select ename,sal,comm
from employee
where comm >sal*1.10;
/*15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. */
select ename
from employee
where (ename like '%l%l%' and deptno=30) or mgr_id=7782;
/*16. Display the names of employees with experience of over 30 years and under 40 yrs. Count the total number of employees.
select ename
from employee
where months_between(sysdate,to_date(hiredate,'dd-mon-yy')) >+360 and months_between(sysdate,to_date(hiredate,'dd-mon-yy'))<480;
select count(*) as"total employees"
from employee */
/*17. Retrieve the names of departments in ascending order and their employees in descending order. */
select d.dname as "department",e.ename as "employee"
from department d
left join employee e on d.deptno=e.deptno
order by "department" asc,"employee" desc;
/*18. Find out experience of MILLER. 
select ename,(select floor(months_between(sysdate,to_date(heridate,'dd-mon-yy)) /12)) as"experince(years)"
from employee
where ename='miller';*/



