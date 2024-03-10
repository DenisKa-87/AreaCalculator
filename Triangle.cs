using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Triangle : GeometricShape
    {
        public bool IsRight { get; private set; }
        private double[] sides;
        public Triangle(double a, double b, double c) 
        {
            if (!TriangleExists(a, b, c))
            {
                Console.WriteLine("Such triangle does not exists");
                return;
            }
            sides = new double[] { a, b, c };
            IsRight = CheckIsRight(a, b, c);
            Area = CalculateArea();
            
        }

        protected override double CalculateArea()
        {
            double p = 0;
            foreach (var side in sides)
            {
                p += side/2;
            }
            return Math.Sqrt(p * (p - sides[0])*(p - sides[1])* (p - sides[2]));
        }

        private bool TriangleExists(double a, double b, double c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }

        private bool CheckIsRight(double a, double b, double c)
        { 
            Array.Sort(sides);
            return sides[2] * sides[2] == sides[1]*sides[1] + sides[0]*sides[0];
        }
    }
}
