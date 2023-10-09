question1:(answer)
create database sqlexam
use sqlexam;
create table book(
     id int  primary key,
	 isbn varchar(15) unique not null,
	 title varchar(255) not null,
	 author varchar(255) not null,
	 published_date datetime not null
	 );
insert into book(id,isbn,title,author,published_date)
values(1,'981483029217','my first sql book','mary parker','2012-02-22 12:08:17');
insert into book(id,isbn,title,author,published_date)
values(2,'857300923713','my second sql book','john mayer','1972-07-03 09:22:45');
insert into book(id,isbn,title,author,published_date)
values(3,'523120967812','my third sql book','cary flint','2015-10-18 14:05:44');
create table reviews(
     id int  primary key,
	 book_id int not null,
	 reviewr_name varchar(255) not null,
	 content text not null,
	 rating int not null,
	 published_date datetime not null
	 );
insert into reviews(id,book_id,reviewr_name,content,rating,published_date)
values(1,1,'john simth','my first review',4,'2017-12-10 05:50:11.1');
insert into reviews(id,book_id,reviewr_name,content,rating,published_date)
values(2,2,'john simth','my second review',5,'2017-10-13 15:05:12.6');
insert into reviews(id,book_id,reviewr_name,content,rating,published_date)
values(3,2,'alice walker','another review',1,'2017-10-22 23:47:10.1');
   
select b.title,b.author,r.reviewr_name
from book b
join reviews r on b.id=r.book_id
where b.author like '%er';


question2:answer
create database q1
use q1;
create table books(
     id int  primary key,
	 isbn varchar(15) unique not null,
	 title varchar(255) not null,
	 author varchar(255) not null,
	 published_date datetime not null
	 );
insert into books(id,isbn,title,author,published_date)
values(1,'981483029217','my first sql book','mary parker','2012-02-22 12:08:17');
insert into books(id,isbn,title,author,published_date)
values(2,'857300923713','my second sql book','john mayer','1972-07-03 09:22:45');
insert into books(id,isbn,title,author,published_date)
values(3,'523120967812','my third sql book','cary flint','2015-10-18 14:05:44');
create table review(
     id int  primary key,
	 book_id int not null,
	 reviewr_name varchar(255) not null,
	 content text not null,
	 rating int not null,
	 published_date datetime not null
	 );
insert into review(id,book_id,reviewr_name,content,rating,published_date)
values(1,1,'john simth','my first review',4,'2017-12-10 05:50:11.1');
insert into review(id,book_id,reviewr_name,content,rating,published_date)
values(2,2,'john simth','my second review',5,'2017-10-13 15:05:12.6');
insert into review(id,book_id,reviewr_name,content,rating,published_date)
values(3,2,'alice walker','another review',1,'2017-10-22 23:47:10.1');

select reviewr_name
from review
group by reviewr_name
having COUNT(distinct book_id)>1;

question3:answer

create database q3
use q3;
create table employee(
     id int primary key,
	 name varchar(255),
	 age int,
	 address varchar(255),
	 salary decimal(10,2)
);
insert into employee (id,name,age,address,salary)
values(1,'ramesh',32,'ahmedabad',2000.00),
      (2,'khilan',25,'delhi',1500.00),
      (3,'kaushik',23,'kota',2000.00),
	  (4,'chaitali',25,'mumbai',6500.00),
	  (5,'hardik',27,'bhopal',8500.00),
	  (1,'komal',22,'benguluru',4500.00),
	  (7,'muffy',24,'indore',10000.00);
create table orders(
     oid int primary key,
	 date date,
	 customer_id int,
	 amount decimal(10,2)
	 );
insert into orders (oid,date,customer_id,amount)values
    (132,'2009-10-08',3,3000.00),
	(180,'2009-11-20',3,1588.00),
	(101,'2009-10-08',2,1566.00),
	(103,'2008-05-20',4,2060.00);

select name
from employee
where address like '%o%';

question q4:answer
create database q3
use q3;
create table employee(
     id int primary key,
	 name varchar(255),
	 age int,
	 address varchar(255),
	 salary decimal(10,2)
);
insert into employee (id,name,age,address,salary)
values(1,'ramesh',32,'ahmedabad',2000.00),
      (2,'khilan',25,'delhi',1500.00),
      (3,'kaushik',23,'kota',2000.00),
	  (4,'chaitali',25,'mumbai',6500.00),
	  (5,'hardik',27,'bhopal',8500.00),
	  (1,'komal',22,'benguluru',4500.00),
	  (7,'muffy',24,'indore',10000.00);
create table orders(
     oid int primary key,
	 date date,
	 customer_id int,
	 amount decimal(10,2)
	 );
insert into orders (oid,date,customer_id,amount)values
    (132,'2009-10-08',3,3000.00),
	(180,'2009-11-20',3,1588.00),
	(101,'2009-10-08',2,1566.00),
	(103,'2008-05-20',4,2060.00);

select date ,count(distinct customer_id) as totalcustomers
from orders
group by date;


question5:answer


question6:answer
select gender,count(*) as total
from studentdetails
group by gender


