using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign1
{
    class Program
    {
        static DataClasses1DataContext DC = new DataClasses1DataContext();
        private static IEnumerable<object> employeeJoinedBeforeCutOff;
        private static object e;
        private static IEnumerable<object> empList;

        static void Main(string[] args)
        {
            var emp = DC.Employees.ToList();

            foreach (var e in emp)
            {
                Console.WriteLine($"{e.EmployeeID} {e.FirstName}, {e.LastName},{e.Title},{e.DOB},{e.DOJ},{e.City}");
            }
            Console.WriteLine("--------------------");
            Console.Read();
            // 1. Display employees joined before 1/1/2015

            var joinedBefore2015 = empList.Where(e => e.DOJ < new DateTime(2015, 1, 1));

            Console.WriteLine("Employees joined before 1/1/2015:");

            foreach (var e in joinedBefore2015)

            {

                Console.WriteLine($"{e.FirstName} {e.LastName}");

            }



            // 2. Display employees with DOB after 1/1/1990

            var dobAfter1990 = empList.Where(e => e.DOB > new DateTime(1990, 1, 1));

            Console.WriteLine("\nEmployees with DOB after 1/1/1990:");

            foreach (var e in dobAfter1990)

            {

                Console.WriteLine($"{e.FirstName} {e.LastName}");

            }



            // 3. Display Consultants and Associates

            var consultantsAndAssociates = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");

            Console.WriteLine("\nConsultants and Associates:");

            foreach (var e in consultantsAndAssociates)

            {

                Console.WriteLine($"{e.FirstName} {e.LastName}");

            }



            // 4. Total number of employees

            int totalEmployees = empList.Count;

            Console.WriteLine($"\nTotal number of employees: {totalEmployees}");



            // 5. Total number of employees in Chennai

            int chennaiEmployees = empList.Count(e => e.City == "Chennai");

            Console.WriteLine($"Total employees in Chennai: {chennaiEmployees}");



            // 6. Highest Employee ID

            int highestEmployeeID = empList.Max(e => e.EmployeeID);

            Console.WriteLine($"Highest Employee ID: {highestEmployeeID}");



            // 7. Employees joined after 1/1/2015

            int employeesJoinedAfter2015 = empList.Count(e => e.DOJ > new DateTime(2015, 1, 1));

            Console.WriteLine($"Employees joined after 1/1/2015: {employeesJoinedAfter2015}");



            // 8. Total employees with designation not "Associate"

            int nonAssociateEmployees = empList.Count(e => e.Title != "Associate");

            Console.WriteLine($"Employees with designation not 'Associate': {nonAssociateEmployees}");



            // 9. Total employees based on City

            var totalEmployeesByCity = empList.GroupBy(emp => emp.City).Select(group => new

            {

                City = group.Key,

                Count = group.Count()

            });

            Console.WriteLine("\nTotal employees based on City:");

            foreach (var cityGroup in totalEmployeesByCity)

            {

                Console.WriteLine($"{cityGroup.City}: {cityGroup.Count}");

            }



            // 10. Total employees based on City and Title

            var totalEmployeesByCityAndTitle = empList.GroupBy(e => new { e.City, e.Title }).Select(group => new

            {

                City = group.Key.City,

                Title = group.Key.Title,

                Count = group.Count()

            });

            Console.WriteLine("\nTotal employees based on City and Title:");

            foreach (var cityTitleGroup in totalEmployeesByCityAndTitle)

            {

                Console.WriteLine($"{cityTitleGroup.City}, {cityTitleGroup.Title}: {cityTitleGroup.Count}");

            }



            // 11. Youngest employee

            var youngestEmployee = empList.OrderBy(e => e.DOB).First();

            Console.WriteLine($"\nYoungest employee: {youngestEmployee.FirstName} {youngestEmployee.LastName}");

        }

    }


}

        
    }
}
