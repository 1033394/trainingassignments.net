create database cs1
use cs1;
CREATE TABLE  student (
    id INT,
    name VARCHAR(255) NOT NULL,
    dob DATE NOT NULL,
    
);
 
CREATE TABLE  course (
    id INT ,
    name VARCHAR(255) NOT NULL,
    description VARCHAR(255) NOT NULL,
   
);
 
CREATE TABLE enrollment (
    
    student_id INT NOT NULL,
    course_id INT NOT NULL,
    enrollment_date DATE NOT NULL,
    
);
INSERT INTO student (id,name,dob ) VALUES
(1,'teju', '2000-01-01'),
(2,'nagu', '2001-02-02');
SELECT * FROM Student;
select*from student
where id=id
 
INSERT INTO course (id,name, description) VALUES
(3,'English', 'English Language Course'),
(1,'Math', 'Mathematics Course'),
(2,'Science', 'Science Course');
 
INSERT INTO enrollment (student_id, course_id, enrollment_date) VALUES
(1, 1, '2021-09-01'),
(1, 2, '2021-09-01'),
(1, 3, '2021-09-01'),
(2, 1, '2021-09-01'),
(2, 2, '2021-09-01'),
(2, 3, '2021-09-01');


UPDATE Student
SET Name = 'lucky', dob='2001-08-28'
WHERE ID = 1;
select *from course;
select*from enrollment
where student_id=student_id