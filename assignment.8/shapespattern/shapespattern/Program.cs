using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapesfactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter shape type :");
            string cardType = Console.ReadLine();

            Ishapes cc = shapesfactory.Getshapes(shapeType);


            if (cc != null)
            {
                Console.WriteLine("shape : {0}", cc.Getshape());
                Console.WriteLine("area : {0}", cc.GetArea());
                Console.WriteLine("circumference : {0}", cc.Getcircumference());
            }
            else
            {
                Console.WriteLine("Invalid shape. please give correct type");
            }
            Console.Read();
        }
    }
}
