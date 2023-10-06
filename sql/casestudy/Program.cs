using System;
using System.Collections.Generic;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Student(int id, string name, DateTime dateOfBirth)
    {
        Id = id;
        Name = name;
        DateOfBirth = dateOfBirth;
    }
}

public class Info
{
    public void Display(Student student)
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine("ID: " + student.Id);
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("DOB: " + student.DateOfBirth);
    }

    public void DisplayEnrollment(Enroll enrollment)
    {
        Console.WriteLine("Enrollment Details:");
        Console.WriteLine("Student ID: " + enrollment.Student.Id);
        Console.WriteLine("Course: " + enrollment.Course);
        Console.WriteLine("Enrollment Date: " + enrollment.EnrollmentDate);
    }
}

public class App
{
    public void Scenario1()
    {
        Student student1 = new Student(1, "John", new DateTime(2000, 1, 1));
        Student student2 = new Student(2, "Jane", new DateTime(2001, 2, 2));

        Info info = new Info();
        info.Display(student1);
        info.Display(student2);
    }

    public void Scenario2()
    {
        Student[] students = new Student[2];
        students[0] = new Student(3, "Alice", new DateTime(1999, 3, 3));
        students[1] = new Student(4, "Bob", new DateTime(1998, 4, 4));

        Info info = new Info();
        foreach (Student student in students)
        {
            info.Display(student);
        }
    }
}

public class Enroll
{
    private Student student;
    private string course;
    private DateTime enrollmentDate;

    public Enroll(Student student, string course, DateTime enrollmentDate)
    {
        this.student = student;
        this.course = course;
        this.enrollmentDate = enrollmentDate;
    }

    public Student Student { get { return student; } }
    public string Course { get { return course; } }
    public DateTime EnrollmentDate { get { return enrollmentDate; } }
}

public class AppEngine
{
    private List<Student> students;
    private List<Enroll> enrollments;

    public AppEngine()
    {
        students = new List<Student>();
        enrollments = new List<Enroll>();
    }

    public void Introduce(string course)
    {
        Console.WriteLine("New Course Introduced: " + course);
    }

    public void Register(Student student)
    {
        students.Add(student);
        Console.WriteLine("Student Registered: " + student.Name);
    }

    public Student[] ListOfStudents()
    {
        return students.ToArray();
    }

    public Enroll[] ListOfEnrollments()
    {
        return enrollments.ToArray();
    }

    public void Enroll(Student student, string course, DateTime enrollmentDate)
    {
        enrollments.Add(new Enroll(student, course, enrollmentDate));
        Console.WriteLine("Student Enrolled: " + student.Name + " for " + course);
    }
}

public abstract class UserInterface
{
    public abstract void ShowFirstScreen();
    public abstract void ShowStudentScreen();
    public abstract void ShowAdminScreen();
    public abstract void ShowAllStudentsScreen();
    public abstract void ShowStudentRegistrationScreen();
    public abstract void IntroduceNewCourseScreen();
    public abstract void ShowAllCoursesScreen();
}

public class ConsoleUserInterface : UserInterface
{
    private AppEngine appEngine;

    public ConsoleUserInterface()
    {
        appEngine = new AppEngine();
    }

    public override void ShowFirstScreen()
    {
        Console.WriteLine("Welcome to SMS (Student Mgmt. System) v1.0");
        Console.WriteLine("Tell us who you are:");
        Console.WriteLine("1. Student");
        Console.WriteLine("2. Admin");
        Console.WriteLine("Enter your choice (1 or 2):");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ShowStudentScreen();
                break;
            case 2:
                ShowAdminScreen();
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    public override void ShowStudentScreen()
    {
        Console.WriteLine("Student Screen");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. View Enrollments");
        Console.WriteLine("Enter your choice (1 or 2):");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ShowStudentRegistrationScreen();
                break;
            case 2:
                ShowAllStudentsScreen();
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    public override void ShowAdminScreen()
    {
        Console.WriteLine("Admin Screen");
        Console.WriteLine("1. Introduce New Course");
        Console.WriteLine("2. View All Courses");
        Console.WriteLine("Enter your choice (1 or 2):");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                IntroduceNewCourseScreen();
                break;
            case 2:
                ShowAllCoursesScreen();
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    public override void ShowAllStudentsScreen()
    {
        Console.WriteLine("All Students");
        Student[] students = appEngine.ListOfStudents();
        foreach (Student student in students)
        {
            Console.WriteLine("Name: " + student.Name + ", ID: " + student.Id);
        }
    }

    public override void ShowStudentRegistrationScreen()
    {
        Console.WriteLine("Student Registration");
        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter student ID:");
        int id = Convert.ToInt32(Console.ReadLine());

        Student student = new Student(id, name, DateTime.Now);
        appEngine.Register(student);
    }

    public override void IntroduceNewCourseScreen()
    {
        Console.WriteLine("Introduce New Course");
        Console.WriteLine("Enter course name:");
        string course = Console.ReadLine();

        appEngine.Introduce(course);
    }

    public override void ShowAllCoursesScreen()
    {
        Console.WriteLine("All Courses");
        Enroll[] enrollments = appEngine.ListOfEnrollments();
        foreach (Enroll enrollment in enrollments)
        {
            Console.WriteLine("Student: " + enrollment.Student.Name + ", Course: " + enrollment.Course);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ConsoleUserInterface userInterface = new ConsoleUserInterface();
        userInterface.ShowFirstScreen();
    }
}