using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapesfactory
{
    public class  shapesfactory
    {
        public static ssc Getshapes(string shapeType)
        {
            Ishapes ssc = null;
            if (shapeType == "circle")
            {
                ssc = new circle();
            }
            else if (shapeType == "rectangle")
            {
                ssc = new rectangle();
            }
            else if (shapeType == "Triangle")
            {
                ssc = new Triangle();
            }
            return (ssc)ssc;
        }
    }
}
