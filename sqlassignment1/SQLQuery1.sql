create database assignment1
use assignment1;
CREATE TABLE Clients (
    Client_ID number(4) PRIMARY KEY,
    Cname VARCHAR(40) NOT NULL,
    Address VARCHAR(30),
	Email VARCHAR(30) UNIQUE,
	phone number(10),
	Business VARCHAR(20) NOT NULL
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
	dname varchar(15) not null,
	loc varchar(20));
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
	 descr varchar(30) not null,
	 start_date date,
	 planned_end_date date,
	 actual_end_date date,
	 budget number(10) check(budget>0),
	 client_id number(4) references
	 clients(client_id));
insert into projects(project_id,descr,start_date,planned_end_date,actual_end_date,budget,client_id)
values(401,'inventory','01-apr-11','01-oct-11','31-oct-11',150000,1001);
insert into projects(project_id,descr,start_date,planned_end_date,actual_end_date,budget,client_id)
values(402,'accounting','01-aug-11','01-jan-12',null,500000,1002);
insert into projects(project_id,descr,start_date,planned_end_date,actual_end_date,budget,client_id)
values(403,'payroll','01-oct-11','31-dec-11',null,750000,1003);
insert into projects(project_id,descr,start_date,planned_end_date,actual_end_date,budget,client_id)
values(404,'contact mgmt','01-nov-11','31-dec-11',null,500000,1004);
create table empprojectasks(
     project_id number(3) references
	 projects(project_id),
	 empno number(4) references employees(empno),
	 start_date date,
	 end_date date,
	 task varchar(25) not null,
	 status varchar(15) not null,
	 primary key(project_id,empno));
insert into empprojectasks(project_id,empno,start_date,end_date,task,status)
values(401,7001,'01-apr-11','20-apr-11','system analysis','completed');
insert into empprojectasks(project_id,empno,start_date,end_date,task,status)
values(401,7002,'21-apr-11','30-mar-11','system design','completed');
insert into empprojectasks(project_id,empno,start_date,end_date,task,status)
values(401,7003,'01-jun-11','15-jul-11','coding','completed');
insert into empprojectasks(project_id,empno,start_date,end_date,task,status)
values(401,7004,'18-jul-11','01-sep-11','coding','completed');
insert into empprojectasks(project_id,empno,start_date,end_date,task,status)
values(401,7006,'03-sep-11','15-sep-11','testing','completed');
insert into empprojectasks(project_id,empno,start_date,end_date,task,status)
values(401,7009,'18-sep-11','05-oct-11','code change','completed');
insert into empprojectasks(project_id,empno,start_date,end_date,task,status)
values(401,7008,'06-oct-11','16-oct-11','testing','completed');
insert into empprojectasks(project_id,empno,start_date,end_date,task,status)
values(401,7007,'06-oct-11','22-oct-11','documentation','completed');
insert into empprojectasks(project_id,empno,start_date,end_date,task,status)
values(401,7011,'22-oct-11','31-oct-11','sign off','completed');
insert into empprojectasks(project_id,empno,start_date,end_date,task,status)
values(401,7010,'01-aug-11','20-aug-11','system analysis','completed');
insert into empprojectasks(project_id,empno,start_date,end_date,task,status)
values(401,7002,'22-aug-11','30-sep-11','system design','completed');
insert into empprojectasks(project_id,empno,start_date,end_date,task,status)
values(401,7004,'01-oct-11',null,'coding','in progress');























