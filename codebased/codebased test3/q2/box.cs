using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class box
    {
       public double length { get; set; }
       public double breadth { get; set; }
       public box(double length,double breadth)
       { 
            length = length;
            breadth = breadth;
       }
       public box Add(box otherbox)
       {
            double newlength = length + otherbox.length;
            double newbreadth = breadth + otherbox.breadth;
            return new box(newlength, newbreadth);
       }
       public void displaydetails()
       {
            Console.WriteLine($"length:{length},breadth:{breadth}");
           
       }

    }
    class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter dimensions for the first box:");
            Console.Write("length:");
            double length1 = double.Parse(Console.ReadLine());
            Console.Write("breadth:");
            double breadth1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter dimensions for the second box:");
            Console.Write("length:");
            double length2 = double.Parse(Console.ReadLine());
            Console.Write("breadth:");
            double breadth2 = double.Parse(Console.ReadLine());
            box box1 = new box(length1, breadth1);
            box box2 = new box(length2, breadth2);
            box box3 = box1.Add(box2);
            Console.WriteLine("details of first box:");
            box1.displaydetails();
            Console.WriteLine("details of second box:");
            box2.displaydetails();
            Console.WriteLine("details of third box(result of add):");
            box3.displaydetails();
        }
    }

}
