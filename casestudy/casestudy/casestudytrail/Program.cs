using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

// Student.cs
public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime DOB { get; set; }

    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new ConsoleUI();
            ui.ShowFirstScreen();
        }
    }
}

// Course.cs
public class Course
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Course() { }

    public Course(int id, string name, string desc)
    {
        this.ID = id;
        this.Name = name;
        this.Description = desc;
    }
}

// Enrollment.cs
public class Enrollment
{
    public int StudentID { get; set; }
    public int CourseID { get; set; }
    public DateTime EnrollDate { get; set; }
    public string CourseName { get; internal set; }
    public int ID { get; internal set; }

    public Enrollment() { }

    public Enrollment(int studentId, int courseId, DateTime enrollDate)
    {
        this.StudentID = studentId;
        this.CourseID = courseId;
        this.EnrollDate = enrollDate;
    }
}

public abstract class UserInterface
{
    public abstract void ShowFirstScreen();

    public abstract void ShowStudentScreen(Student student);

    public abstract void ShowAdminScreen();

    public abstract void ShowAllStudentsScreen();

    public abstract void ShowStudentRegistrationScreen();

    public abstract void ShowAllCoursesScreen();

    public abstract void ShowCourseDetailsScreen(Course course);

    public abstract void EnrollInCourseScreen(Student student, List<Course> courses);

    public abstract void UpdateStudentScreen(Student student);

    public abstract void UpdateCourseScreen(Course course);
}

public class ConsoleUI : UserInterface
{
    private AppEngine engine = new AppEngine();

    public override void ShowFirstScreen()
    {
        Console.WriteLine("Welcome to Student Management System!");
        Console.WriteLine("1. Student Login");
        Console.WriteLine("2. Admin Login");
        Console.Write("Choose option: ");

        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            ShowStudentLoginScreen();
        }
        else if (choice == 2)
        {
            ShowAdminLoginScreen();
        }
    }

    public override void ShowStudentScreen(Student student)
    {
        Console.WriteLine("Welcome " + student.Name);
        Console.WriteLine("1. View Courses");
        Console.WriteLine("2. Enroll in Course");
        // other options

        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            ShowEnrolledCourses(student);
        }
        else if (choice == 2)
        {
            ShowAvailableCourses(student);
        }
    }

    private void ShowAvailableCourses(Student student)
    {
        throw new NotImplementedException();
    }

    private void ShowEnrolledCourses(Student student)
    {
        throw new NotImplementedException();
    }

    public override void ShowAdminScreen()
    {
        Console.WriteLine("Admin Dashboard");
        Console.WriteLine("1. Register New Student");
        Console.WriteLine("2. Add New Course");

        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            ShowStudentRegistrationScreen();
        }
        else if (choice == 2)
        {
            ShowAddCourseScreen();
        }
        else if(choice == 3)
        {

        }
    }


    public override void ShowAllStudentsScreen()
    {
        List<Student> students = engine.GetStudentEnrollments();
        Console.WriteLine("All Students");
        foreach (Student s in students)
        {
            Console.WriteLine(s.Name);
        }
    }

    public override void ShowStudentRegistrationScreen()
    {
        Student student = new Student();
        Console.Write("Name: ");
        student.Name = Console.ReadLine();
        Console.Write("DOB: ");
        student.DOB = DateTime.Parse(Console.ReadLine());

        engine.RegisterStudent(student);
        Console.WriteLine("Student Registered!");
    }

    public override void ShowAllCoursesScreen()
    {
        List<Course> courses = engine.GetCourses();
        Console.WriteLine("All Courses");
        foreach (Course c in courses)
        {
            Console.WriteLine(c.Name);
        }
    }

    public override void UpdateStudentScreen(Student student)
    {
        Console.Write("New Name: ");
        student.Name = Console.ReadLine();
        engine.UpdateStudent(student);
        Console.WriteLine("Student Updated!");
    }

public override void ShowCourseDetailsScreen(Course course)
    {

        Console.WriteLine("Course Details");
        Console.WriteLine("Name: " + course.Name);
        Console.WriteLine("Description: " + course.Description);

    }

    public override void EnrollInCourseScreen(Student student, List<Course> courses)
    {

        Console.WriteLine("Available Courses:");
        foreach (Course c in courses)
        {
            Console.WriteLine(c.Name);
        }

        Console.Write("Enter course to enroll in: ");
        int courseId = Convert.ToInt32(Console.ReadLine());

        engine.EnrollStudent(student.ID, courseId);

        Console.WriteLine("Enrolled successfully!");

    }

    public override void UpdateCourseScreen(Course course)
    {

        Console.Write("New name: ");
        course.Name = Console.ReadLine();

        Console.Write("New description: ");
        course.Description = Console.ReadLine();

        engine.UpdateCourse(course);

        Console.WriteLine("Course updated!");

    }

    public void ShowAdminLoginScreen()
    {

        Console.Write("Enter admin username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (username == "admin" && password == "123456")
        {
            ShowAdminScreen();
        }
        else
        {
            Console.WriteLine("Invalid credentials");
        }

    }

    public void ShowStudentLoginScreen()
    {

        Console.Write("Enter student ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Student student = engine.GetStudent(id);

        if (student != null)
        {
            ShowStudentScreen(student);
        }
        else
        {
            Console.WriteLine("Invalid student ID");
        }

    }
}

public class AppEngine
{
    private string connectionString = "Data Source=ICS-LT-987J8G3;Initial Catalog=cs1;Integrated Security=True";

    public void RegisterStudent(Student student)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "INSERT INTO Students VALUES (@Name, @DOB)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = student.Name;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = student.DOB;

                cmd.ExecuteNonQuery();
            }
        }
    }

    // Implement GetStudent method
    public Student GetStudent(int id)
    {
        Student student = null;

        string sql = "SELECT * FROM Students WHERE ID = @Id";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        student = new Student();
                        student.ID = (int)reader["ID"];
                        student.Name = (string)reader["Name"];
                        student.DOB = (DateTime)reader["DOB"];
                    }
                }
            }
        }

        return student;
    }

    // Implement UpdateStudent method
    public void UpdateStudent(Student student)
    {
        string sql = "UPDATE Students SET Name = @Name WHERE ID = @Id";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = student.ID;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = student.Name;

                cmd.ExecuteNonQuery();
            }
        }
    }

    // Implement GetStudentEnrollments method
    public List<Enrollment> GetStudentEnrollments(int studentId)
    {
        List<Enrollment> enrollments = new List<Enrollment>();

        string sql = @"SELECT e.*, c.Name AS CourseName
                FROM Enrollments e
                JOIN Courses c ON e.CourseId = c.Id
                WHERE e.StudentId = @StudentId";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Enrollment enrol = new Enrollment();
                        enrol.ID = (int)reader["ID"];
                        enrol.StudentID = (int)reader["StudentId"];
                        enrol.CourseID = (int)reader["CourseId"];
                        enrol.EnrollDate = (DateTime)reader["EnrollDate"];
                        enrol.CourseName = (string)reader["CourseName"];

                        enrollments.Add(enrol);
                    }
                }
            }
        }

        return enrollments;
    }

    // Implement UpdateCourse method
    public void UpdateCourse(Course course)
    {
        string sql = "UPDATE Courses SET Name = @Name, Description = @Desc WHERE ID = @Id";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = course.ID;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = course.Name;
                cmd.Parameters.Add("@Desc", SqlDbType.VarChar).Value = course.Description;

                cmd.ExecuteNonQuery();
            }
        }
    }
}

