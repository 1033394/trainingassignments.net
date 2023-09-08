using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_assignment2
{
    class q1
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            double average = CalculateAverage(arr);
            int minimum = FindMinimum(arr);
            int maximum = FindMaximum(arr);
            Console.WriteLine("Array: [" + string.Join(",", arr) + "]");
            Console.ReadLine();
            Console.WriteLine("Average value: " + average);
            Console.ReadLine();
            Console.WriteLine("Minimum value: " + minimum);
            Console.ReadLine();
            Console.WriteLine("Maximum value: " + maximum);
            Console.ReadLine();


        }
        static double CalculateAverage(int[] arr)
        {
            double sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum / arr.Length;
        }
        static int FindMinimum(int[] arr)
        {
            int min = arr[0];
            foreach(int num in arr)
            {
                if(num<min)
                {
                    min = num;
                }
            }
            return min;
        }
        static int FindMaximum(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
