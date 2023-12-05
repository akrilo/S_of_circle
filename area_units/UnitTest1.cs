using NUnit.Framework;
using System;
using area;

namespace area_units
{
    [TestFixture]
    public class AreaTests
    {
        [Test]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            var circle = new Circle(radius);

            Assert.AreEqual(expectedArea, circle.CalculateArea(), 0.001);
        }

        [Test]
        public void TriangleArea_CorrectArea()
        {
            double A = 3;
            double B = 4;
            double C = 5;

            double expectedArea = Math.Sqrt((A + B + C) * (A + B - C) * (A - B + C) * (-A + B + C)) / 4;

            var triangle = new Triangle(A, B, C);

            Assert.AreEqual(expectedArea, triangle.CalculateArea(), 0.001);
        }

        [Test]
        public void IsRightAngled_True()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.IsTrue(triangle.IsRightAngled());
        }

        [Test]
        public void IsRightAngled_False()
        {
            var triangle = new Triangle(3, 4, 6);

            Assert.IsFalse(triangle.IsRightAngled());
        }
    }
}