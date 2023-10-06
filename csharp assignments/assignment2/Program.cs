using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];
            int total = 0;
            Console.WriteLine("Enter numbers:");
            for (int i=0;i<10;i++)
            {
                Console.WriteLine($"Enter marks {i+1}:");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                total += marks[i];

            }
            double average = (double)total / 10;
            int minMark = marks[0];
            int maxMark = marks[0];
            foreach(int mark in marks)
            {
                if (mark < minMark)
                    minMark = mark;
                if (mark < maxMark)
                    maxMark = mark;

            }
            Array.Sort(marks);
            Array.Reverse(marks);
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average {i + 1}:");

        }
    }
}
