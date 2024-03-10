using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Circle : GeometricShape
    {
        
        public double Radius { get; internal set; }  
        public Circle(double radius) { 
            if(radius <= 0)
            {
                Console.WriteLine("Please enter a valid radius value");
                return;
            }
            Radius = radius;
            Area = CalculateArea();
        }
        protected override double CalculateArea()
        {
            return Math.PI * Radius*Radius;
        }
    }
}
