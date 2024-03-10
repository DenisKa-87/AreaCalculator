using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public abstract class GeometricShape
    {
        private double area;
        public double Area { get ; internal set; }
        protected abstract double CalculateArea();
    }
}
