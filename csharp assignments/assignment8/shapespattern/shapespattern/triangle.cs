using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapesfactory
{
    public class Triangle : Ishapes
    {
        public double side1 { get; }
        public double side2 { get; }
        public double side3 { get; }
        public Triangle(double side1, double side2, double side3)
        {
            side1 = side1;
            side2 = side2;
            side3 = side3;
        }

        public Triangle()
        {
        }

        public string Getshape()
        {
            return "triangle";
        }

        public double GetArea()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public double Getcircumference()
        {
            return side1 + side2 + side3;
        }
    }
}