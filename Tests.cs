using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    [TestFixture]
    internal class Tests
    {
        [TestCase(1, Math.PI)]
        [TestCase(-1, 0)]
        public void Test(double radius, double expectedArea)
        {
            var area =new AreaCalculator(radius).Shape.Area;
            ClassicAssert.AreEqual(expectedArea, area);
        }

        [TestCase(3,4,5,true)]
        [TestCase(1,1,2, false)]
        [TestCase(1, 1, 1, false)]
        public void TestTriangle(double a, double b, double c,  bool isRight)
        {
            var p = (a+b+c)/2;
            var expectedArea = Math.Sqrt(p*(p-a) * (p - b) * (p - c));
            var calc = new AreaCalculator(a,b,c);
            var area = calc.Shape.Area;
            ClassicAssert.AreEqual(expectedArea, area);
            if (calc.Shape.GetType() == typeof(Triangle))
            {
                var shape = (Triangle) calc.Shape;
                ClassicAssert.AreEqual(shape.IsRight, isRight);
            }
            
        }
    }
}
