using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapesfactory
{
    public class rectangle : Ishapes
    {
        private double length { get; }
        private double width { get; }
        public rectangle(double length, double width)
        {
            length = length;
            width = width;
        }

        public rectangle()
        {
        }

        public string Getshape()
        {
            return "rectangle";
        }

        public double GetArea()
        {
            return length * width;
        }

        public double Getcircumference()
        {
            return(length + width);
            
        }

      
    }
}