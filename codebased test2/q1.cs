using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebase2
{
    abstract class student
    {
        public string name { get; set; }
        public int studentid { get; set; }
        public double grade { get; set; }
        public abstract bool ispassed(double grade);
    }

    class undergraduate : student
    {
        public override bool ispassed(double grade)
        {
            return grade > 70.0;
        }


    }

    class gradute : student
    {
        public override bool ispassed(double grade)
        {
            return grade > 80.0;
        }

    }
    class program
    {
        static void main(string[] args)
        {




            var undergradestudent = new undergraduate
            {
                name = "teju",
                studentid = 30,
                grade = 75.0

            };
            bool undergradpassed = undergradestudent.ispassed(undergradestudent.grade);
            Console.WriteLine($" graduate student{undergradestudent.name}" + $"with id {undergradestudent.studentid}" + $"has{(undergradepassed ? "passed" : "failed")}.");

            var gradestudent = new gradute
            {
                name = "nagu",
                studentid = 45,
                grade = 85.0

            };
            bool gradepassed = gradestudent.ispassed(gradestudent.grade);
            Console.WriteLine($" graduate student{gradestudent.name}" + $"with id {gradestudent.studentid}" + $"has{(gradepassed ? "passed" : "failed")}");

        }
    }

}

