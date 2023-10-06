using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_assignment
{
    class q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("num1 and num2 are equal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("num1 and num2 are not equal");
                Console.ReadLine();
            }


        }
    }
}
