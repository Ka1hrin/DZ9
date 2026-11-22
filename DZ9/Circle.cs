using System;

namespace DZ9
{
    internal class Circle : Point
    {
        public override string Name { get { return "Окружность"; } }
        private double _radius;

        public Circle(FigureColor color, double x, double y, double radius) : base(color, x, y)
        {
            Radius = radius;
        }

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Радиус не может быть отрицательным!");
                
                _radius = value;
            }
        }

        /// <summary>
        /// Посчитать площадь круга
        /// </summary>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        /// <summary>
        /// Вывести информацию о круге
        /// </summary>
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Радиус окружности: {_radius}");
        }
    }
}
