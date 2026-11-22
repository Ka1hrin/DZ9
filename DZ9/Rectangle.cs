using System;

namespace DZ9
{
    internal class Rectangle : Point
    {
        public override string Name { get { return "Прямоугольник"; } }
        private double _width;
        private double _height;

        public Rectangle(FigureColor color, double x, double y, double width, double height) : base(color, x, y)
        {
            Width = width;
            Height = height;
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Ширина не может быть отрицательной!");

                _width = value;
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Высота не может быть отрицательной!");

                _height = value;
            }
        }

        /// <summary>
        /// Посчитать площадь прямоугольника
        /// </summary>
        public override double GetArea()
        {
            return _width * _height;
        }

        /// <summary>
        /// Вывести информацию о прямоугольнике
        /// </summary>
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Ширина: {_width}\nВысота: {_height}");
        }
    }
}
