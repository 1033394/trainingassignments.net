using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class student
    {
        
        private int rollno;
        private string name;
        private string studentclass;
        private string semester;
        private string branch;
        private int[] marks = new int[5];

        public student(int rollno,string name,string studentclass,string semester,string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.studentclass = studentclass;
            this.semester = semester;
            this.branch = branch;

        }
        public void Getmarks(int[] subjectmarks)

        { 
            if(subjectmarks.Length !=5)
            {
                Console.WriteLine("please provide marks for all 5 subjects.");
                return;
            }
            for (int i=0;i<5;i++)
            {
                marks[i] = subjectmarks[i];

            }
        }
        public void displayresult()
        {
            int sum = 0;
            foreach (int mark in marks )
            {
                sum += mark;
                if (mark <35)
                {
                    Console.WriteLine("Result:failed (marks in ICloneable subject <35)");
                    return;
                }
            }
            double avearge = (double)sum / 5;
            if(avearge <= 50)
            {
                Console.WriteLine("result:failed (avearge<50)");

            }
            else
            {
                Console.WriteLine("result: passed");
            }
        }
        public void displaydata()
        {
            Console.WriteLine("roll no:" + rollno);
            Console.WriteLine("name:" + name);
            Console.WriteLine("class:" + studentclass);
            Console.WriteLine("semseter:" + semester);
            Console.WriteLine("branch:" + branch);
            Console.WriteLine("marks:" + string.Join(",",marks));






        }


    }
    
}
