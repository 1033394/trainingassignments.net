create database assignment1
use assignment1;
CREATE TABLE Clients (
    Client_ID NUMBER(4) PRIMARY KEY,
    Cname VARCHAR2(40) NOT NULL,
    Address VARCHAR2(30),
	Email VARCHAR2(30) UNIQUE,
	Phone NUMBER(10),
	Business VARCHAR2(20) NOT NULL
);
insert into Clients
(Client_ID,Cname,Address,Email,Phone,Business)
values(1001,'ACME Utilities','noida','contact@acmeutil.com',9567880032,'manufacturing');
insert into Clients
(Client_ID,Cname,Address,Email,Phone,Business)
values(1002,'trackon consultants','mumbai','consult@trackon.com',8734210090,'consultant');
insert into Clients
(Client_ID,Cname,Address,Email,Phone,Business)
values(1003,'moneysaver','distributors','bangalore','save@moneysaver.com',7799886655,'reseller');
insert into Clients
(Client_ID,Cname,Address,Email,Phone,Business)
values(1004,'lawful corp','chennai','justice@lawful.com',9210342219,'professional');

create table departments(
    deptno number(2) primary key,
	dname varchar2(15) not null,
	loc varchar2(20));
insert into departments(deptno,dname,loc)
values(10,'design','pune');
insert into departments(deptno,dname,loc)
values(20,'development','pune');
insert into departments(deptno,dname,loc)
values(30,'testing','mumbai');
insert into departments(deptno,dname,loc)
values(40,'document','mumbai');

create table employees(
     empno number(4) primary key,
	 ename varchar2(20) not null,
	 job varchar2(15),
	 salary number(7) check (salary>0),
	 deptno number(2) references
	 departments(deptno));
insert into employees(empno,ename,job,salary,deptno)
values(7001,'sandeep','analyst',25000,10);
insert into employees(empno,ename,job,salary,deptno)
values(7002,'rajesh','designer',30000,10);
insert into employees(empno,ename,job,salary,deptno)
values(7003,'madhav','developer',40000,20);
insert into employees(empno,ename,job,salary,deptno)
values(7004,'manoj','developer',40000,20);
insert into employees(empno,ename,job,salary,deptno)
values(7005,'abhay','designer',35000,10);
insert into employees(empno,ename,job,salary,deptno)
values(7006,'uma','tester',30000,30);
insert into employees(empno,ename,job,salary,deptno)
values(7007,'gita','tech.writer',30000,40);
insert into employees(empno,ename,job,salary,deptno)
values(7008,'priya','tester',35000,30);
insert into employees(empno,ename,job,salary,deptno)
values(7009,'nutan','developer',45000,20);
insert into employees(empno,ename,job,salary,deptno)
values(7010,'smita','analyst',20000,10);
insert into employees(empno,ename,job,salary,deptno)
values(7011,'anand','project mgr',65000,10);

create table projects(
     project_id number(3) primary key,
	 descr varchar2(30) not null,
	 start_date date,
	 planned_end_date date,
	 actual_end_date date,
	 budget number(10) check(budget>0),
	 client_id number(4) references,
	 clients(client_id));
insert into projects(project_id,descr,start_date,planned_end_date,actual_end_date,budget,client_id)
values(401,'inventory',to_date('01-apr-11','dd-mon-rr',to_date('01-oct









