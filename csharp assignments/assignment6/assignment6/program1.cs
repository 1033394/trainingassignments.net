using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using concession;

namespace assignment6
{
    class program1
    {
        private const double totalfare = 500.0;
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age:");
            int age =int.Parse( Console.ReadLine());
            concession.concessioncalculator calculator = new concession.concessioncalculator();
            string result = calculator.calculateconcession(age, name);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
