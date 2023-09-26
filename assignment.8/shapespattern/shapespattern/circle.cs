using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapesfactory
{
    public class circle :Ishapes
    {
        private double radius { get; }
        public circle(double radius)
        {
            radius = radius;
        }

        public circle()
        {
        }

        public string Getshape()
        {
            return "circle";
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double Getcircumference()
        {
            return Math.PI* radius;
        }
    }
}
