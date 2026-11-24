using System;

namespace DZ9
{
    internal class Point : Figure
    {
        public override string Name { get { return "Точка"; } }

        public Point(FigureColor color, double x, double y) : base(color, x, y)
        {
        }

        public override double GetArea()
        {
            return 0;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Площадь фигуры '{Name}': {GetArea():F2}");
        }
    }
}
