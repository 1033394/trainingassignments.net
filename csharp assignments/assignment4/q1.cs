using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class q1
    {
        public static void display(string firstname, string lastname)
        {
            string upperfistname = firstname.ToUpper();
            string upperlastname = lastname.ToUpper();
            Console.WriteLine(upperfistname);
            Console.ReadLine();
            Console.WriteLine(upperlastname);
            Console.ReadLine();

        }
    }
    class program
    {
        static void Main()
        {
            Console.Write("enter the first name:");
            string firstname = Console.ReadLine();
            Console.Write("enter the last name:");
            string lastname = Console.ReadLine();
            q1.display(firstname, lastname);


        }
    }
}
