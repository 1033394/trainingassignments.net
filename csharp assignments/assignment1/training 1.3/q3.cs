using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training_1._3
{
    class q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double Sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;
            if(num2!=0)
            {
                double division = num1 / num2;
                Console.WriteLine($"sum: {Sum}");
                Console.ReadLine();
                Console.WriteLine($"difference: {difference}");
                Console.ReadLine();
                Console.WriteLine($"product: {product}");
                Console.ReadLine();
                Console.WriteLine($"divison: {division}");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("division by zero is not allowed.");
                Console.ReadLine();
            }

        }
    }

}
