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
            Console.WriteLine("enter a no: ");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiplication Table for { no}:");
            for (int i=1;i<=10;i++)
            {
                int result = no * i;
                Console.WriteLine($"{no} x {i}={result}");
                Console.ReadLine();
            }
        }
    }
}
