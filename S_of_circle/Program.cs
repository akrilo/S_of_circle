using System;
using area;

namespace S_of_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            var circle = new Circle(radius);
            Console.WriteLine($"Площадь круга с радиусом {radius} равна {circle.CalculateArea()}");

            Console.Write("Введите длину стороны A треугольника: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину стороны B треугольника: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину стороны C треугольника: ");
            double C = Convert.ToDouble(Console.ReadLine());

            var triangle = new Triangle(A, B, C);
            Console.WriteLine($"Площадь треугольника со сторонами {A}, {B}, {C} равна {triangle.CalculateArea()}");

            Console.WriteLine($"Треугольник с заданными сторонами {(triangle.IsRightAngled() ? "является" : "не является")} прямоугольным.");

            Console.ReadLine();
        }
    }
}
