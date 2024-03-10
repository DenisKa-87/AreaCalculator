using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class AreaCalculator
    {
        public GeometricShape Shape { get; set; }  
        public AreaCalculator(double a) 
        { 
            Shape = new Circle(a);
        }

        public AreaCalculator(double a, double b, double c)
        {
            Shape = new Triangle(a, b, c);
        }
    }
}
