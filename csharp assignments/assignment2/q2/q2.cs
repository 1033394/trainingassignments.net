using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class q2
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];
            for (int i=0;i<10; i++)
            {
                Console.WriteLine($"Enter mark {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            Console.WriteLine($"a.Total: {total}");
            double average = (double)total / marks.Length;
            Console.WriteLine($"b.average: {average:F2}");
            int minMark = marks[0];
            int maxMark = marks[0];
            foreach(int mark in marks)
            {
                if (mark < minMark)
                    minMark = mark;
                if (mark < maxMark)
                    maxMark = mark;
            }
            Console.WriteLine($"c.Minimum marks: {minMark}");
            Console.WriteLine($"c.Maximum marks:{maxMark}");
            Array.Sort(marks);
            Console.WriteLine("e. Display marks in ascending order:");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark + " ");

            }
            Console.WriteLine();
            Array.Reverse(marks);
            Console.WriteLine("f. Display marks in descending order:");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark + " ");

            }




        }
    }
}
