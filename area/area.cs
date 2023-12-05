using System;

namespace area
{
    public interface IFigure
    {
        double CalculateArea();
    }

    public class Circle : IFigure
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }

            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle : IFigure
    {
        private double SideA { get; }
        private double SideB { get; }
        private double SideC { get; }

        public Triangle(double A, double B, double C)
        {
            if (A <= 0 || B <= 0 || C <= 0)
            {
                throw new ArgumentException("Все стороны треугольника должны быть положительными числами.");
            }

            SideA = A;
            SideB = B;
            SideC = C;
        }

        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRightAngled()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
