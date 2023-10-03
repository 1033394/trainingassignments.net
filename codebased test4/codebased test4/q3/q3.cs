using System;

using System.Collections.Generic;

using System.Linq;

 

class Program

{

    static void Main()

    {

        // Create a generic list to store employee records

        List<Employee> employees = new List<Employee>

        {

            new Employee

            {

                EmployeeID = 1001,

                FirstName = "Malcolm",

                LastName = "Daruwalla",

                Title = "Manager",

                City = "Mumbai",

                DOB = DateTime.Parse("16/11/1984"),

                StartDate = DateTime.Parse("8/6/2011")

            };


        new Employee
        {
            EmployeeID = 1002,

            FirstName = "Asdin",

            LastName = "Dhalla",

            Title = "AsstManager ",

            City = "Mumbai",

            DOB = DateTime.Parse("20/08/1984"),

            StartDate = DateTime.Parse("7/7/2012 ")
        };
        new Employee 
        {

            EmployeeID = 1003,

            FirstName = "Madhavi",

            LastName = " Oza ",

            Title = "Consultant ",

            City = "Pune",

            DOB = DateTime.Parse(" 14/11/1987 "),

            StartDate = DateTime.Parse("12/4/2015 ")

        },
            
            // Add other employee records similarly

    };



        // LINQ queries



        // a. Display detail of all employees

        var allEmployees = employees;

        Console.WriteLine("a. Display detail of all employees:");

        foreach (var employee in allEmployees)

        {

            Console.WriteLine($"{employee.EmployeeID}, {employee.FirstName}, {employee.LastName}, {employee.Title}, {employee.City}");

        }



        // b. Display details of employees whose location is not Mumbai

        var employeesNotInMumbai = employees.Where(emp => emp.City != "Mumbai");

        Console.WriteLine("\nb. Display details of employees whose location is not Mumbai:");

        foreach (var employee in employeesNotInMumbai)

        {

            Console.WriteLine($"{employee.EmployeeID}, {employee.FirstName}, {employee.LastName}, {employee.Title}, {employee.City}");

        }



        // c. Display details of employees whose title is AsstManager

        var asstManagers = employees.Where(emp => emp.Title == "AsstManager");

        Console.WriteLine("\nc. Display details of employees whose title is AsstManager:");

        foreach (var employee in asstManagers)

        {

            Console.WriteLine($"{employee.EmployeeID}, {employee.FirstName}, {employee.LastName}, {employee.Title}, {employee.City}");

        }



        // d. Display details of employees whose Last Name starts with S

        var employeesWithLastNameStartingWithS = employees.Where(emp => emp.LastName.StartsWith("S"));

        Console.WriteLine("\nd. Display details of employees whose Last Name starts with S:");

        foreach (var employee in employeesWithLastNameStartingWithS)

        {

            Console.WriteLine($"{employee.EmployeeID}, {employee.FirstName}, {employee.LastName}, {employee.Title}, {employee.City}");

        }

    }

}



class Employee

{

    public int EmployeeID { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Title { get; set; }

    public string City { get; set; }

    public DateTime DOB { get; set; }

    public DateTime StartDate { get; set; }

}