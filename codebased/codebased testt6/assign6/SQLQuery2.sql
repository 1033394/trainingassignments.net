create database exam2;
use exam2;
CREATE TABLE Departments (

    DepartmentsId INT PRIMARY KEY,

    DepartmentsName VARCHAR(255) NOT NULL

);
CREATE TABLE Employee (

    EmployeeId INT PRIMARY KEY,

    FirstName VARCHAR(255) NOT NULL,

    LastName VARCHAR(255) NOT NULL,

    Email VARCHAR(255) UNIQUE NOT NULL,

    PhoneNumber VARCHAR(255) NOT NULL,

    HireDate DATE NOT NULL,

    JobId INT,

    Salary FLOAT,

    ManagerId INT,

    DepartmentId INT,
);
INSERT INTO Departments(DepartmentsId, DepartmentsName)

VALUES (10, 'Accounting'),

       (20, 'Research'),

       (30, 'Sales'),

       (40, 'Operations'),

       (50, 'IT'),

       (60, 'HR'),

       (70, 'Shipping'),

       (80, 'Executive'),

       (90, 'Marketing'),

       (100, 'Finance'),

       (110, 'Administration'),

       (120, 'Purchasing'),

       (130, 'Logistics'),

       (140, 'Benefits'),

       (150, 'Training'),

       (160, 'Product Management'),

       (170, 'Support'),

       (180, 'Hardware'),

       (190, 'Quality Management'),

       (200, 'Customer Service'),

       (210, 'Public Relations'),

       (220, 'Design'),

       (230, 'Engineering'),

       (240, 'Manufacturing'),

       (250, 'Consulting'),

       (260, 'Community Relations'),

       (270, 'Software'),

       (280, 'Security'),

       (290, 'Investor Relations'),

       (300, 'Customer Relationship Management'),

       (310, 'Vendor Relationship Management'),

       (320, 'Facilities'),

       (330, 'Production'),

       (340, 'Construction'),

       (350, 'Insurance'),

       (360, 'Recruiting'),

       (370, 'International Sales'),

       (380, 'Internal Audit'),

       (390, 'Inventory'),

       (400, 'Loss Prevention'),

       (410, 'Food Services'),

       (420, 'Security Services'),

       (430, 'Event Planning'),

       (440, 'Custodial'),

       (450, 'Mortgage'),

       (460, 'Personnel'),

       (470, 'Insurance Services'),

       (480, 'Environmental Services'),

       (490, 'Consumer Products'),

       (500, 'Fitness'),

       (510, 'Education'),

       (520, 'Financial Services'),

       (530, 'Utilities'),

       (540, 'Government Relations'),

       (550, 'Non-Profit Organization'),

       (560, 'Franchise'),

       (570, 'Real Estate'),

       (580, 'Acquisitions'),

       (590, 'Strategic Planning'),

       (600, 'Business Development'),

       (610, 'Customer Support'),

       (620, 'E-Commerce'),

       (630, 'Web Services'),

       (640, 'Market Research'),

       (650, 'Apparel'),

       (660, 'Textiles'),

       (670, 'Retail'),

       (680, 'Libraries'),

       (690, 'Banking'),

       (700, 'Transportation'),

       (710, 'Hospitality'),

       (720, 'Cosmetics'),

       (730, 'Toys'),

       (740, 'Medicine'),

       (750, 'Nursing'),

       (760, 'Health Care'),

       (770, 'Pharmaceuticals'),

       (780, 'Entertainment'),

       (790, 'Aerospace'),

       (800, 'Automotive'),

       (810, 'Maritime'),

       (820, 'Agriculture'),

       (830, 'Telecommunications'),

       (840, 'Computer'),

       (850, 'Tourism'),

       (860, 'Dental'),

       (870, 'Hair Salon'),

       (880, 'Florist'),

       (890, 'Pet Grooming'),

       (900, 'Salon Services'),

       (910, 'Veterinary Services'),

       (920, 'Travel'),

       (930, 'Catering'),

       (940, 'Laboratory Services'),

       (950, 'Law'),

       (960, 'Performing Arts'),

       (970, 'Horticulture'),

       (980, 'Gardening'),

       (990, 'Aquariums'),

       (1000, 'Environmental Protection');


INSERT INTO Employee (EmployeeId, FirstName, LastName, Email, PhoneNumber, HireDate, JobId, Salary, ManagerId, DepartmentId)

VALUES (1, 'Steven', 'King', 'SKING', '515.123.4567', '2003-06-17', 2, 24000, NULL, 90),

       (2, 'Neena', 'Kochhar', 'NKOCHHAR', '515.123.4568', '2005-09-21', 1, 17000, 1, 90),

       (3, 'Lex', 'De Haan', 'LDEHAAN', '515.123.4569', '2001-01-13', 3, 17000, 1, 90),

       (4, 'Alexander', 'Hunold', 'AHUNOLD', '590.423.4567', '2005-03-03', 1, 9000, 1, 60),

       (5, 'Bruce', 'Ernst', 'BERNST', '590.423.4568', '2006-05-23', 2, 6000, 2, 60),

       (6, 'David', 'Austin', 'DAUSTIN', '590.423.4569', '2005-06-25', 2, 4800, 2, 60),

       (7, 'Valli', 'Pataballa', 'VPATABALLA', '590.423.4560', '2001-08-07', 3, 4800, 3, 60),

       (8, 'Diana', 'Lorentz', 'DLORENTZ', '590.423.5678', '2007-02-07', 3, 4200, 3, 60),

       (9, 'Den', 'Malone', 'DMALONE', '590.423.5679', '2009-03-19', 3, 8000, 3, 60),

       (10, 'Guy', 'Himuro', 'GHIMURO', '590.423.4570', '2002-02-01', 3, 4000, 3, 60);


select*from Departments
select*from employee