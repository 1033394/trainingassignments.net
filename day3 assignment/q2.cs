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
            Console.WriteLine("Enter a num:");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("The num is positive.");
                Console.ReadLine();
            }
            else if (num < 0)
            {
                Console.WriteLine("The num is negative.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The num is zero.");
                Console.ReadLine();
            }
           
        }
    }
}
