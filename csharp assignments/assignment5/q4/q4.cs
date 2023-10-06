using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    class q4
    {
        public int customerid { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string phone { get; set; }
        public string city { get; set; }

        public q4()
        {
            customerid = 0;
            name = "";
            age = 0;
            phone = "";
            city = "";
        }
        public q4( int customerid, string name, int age, string phone, string city)
        {
            customerid = customerid;
            name = name;
            age = age;
            phone = phone;
            city = city;

        }
         

        public static void displaycustomer(int customerid, string name, int age,string phone, string city)
        {
            Console.WriteLine("customer information:");
            Console.ReadLine();
            Console.WriteLine($"customerid:{customerid}");
            Console.ReadLine();
            Console.WriteLine($"name:{name}");
            Console.ReadLine();
            Console.WriteLine($"age:{age}");
            Console.ReadLine();
            Console.WriteLine($"phone:{phone}");
            Console.ReadLine();
            Console.WriteLine($"city:{city}");
            Console.ReadLine();

        }
       
        
    }
}
