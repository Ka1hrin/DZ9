using System;

namespace DZ9
{
    internal abstract class Figure : ICanChange, ICanMove
    {
        private FigureColor _figureColor;
        public bool IsVisible { get; private set; } 
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }

        public Figure(FigureColor color, double x, double y)
        {
            FigureColor = color;
            IsVisible = true;
            CoordinateX = x;
            CoordinateY = y;
        }
        public FigureColor FigureColor
        {
            get {return  _figureColor;}
            set
            {
                if (!Enum.IsDefined(typeof(FigureColor), value))
                    throw new ArgumentException("Неизвестный цвет!");

                _figureColor = value;
            }
        }
        #region
        /// <summary>
        /// Изменить цвет фигуры
        /// </summary>
        public void ChangeColor(string newColor)
        {
            FigureColor = RusColor.RusStr(newColor);
        }

        /// <summary>
        /// Сделать фигуру видимой
        /// </summary>
        public void Show()
        {
            IsVisible = true;
        }

        /// <summary>
        /// Сделать фигуру невидимой
        /// </summary>
        public void Hide()
        {
            IsVisible = false;
        }

        /// <summary>
        /// Сдвинуть фигуру по горизонтали (по оси х)
        /// </summary>
        public void MoveHorizontal(double dx)
        {
            CoordinateX += dx;
        }

        /// <summary>
        /// Сдвинуть фигуру по вертикали (по оси у)
        /// </summary>
        public void MoveVertical(double dy)
        {
            CoordinateY += dy;
        }
        /// <summary>
        /// Посчитать площадь фигуры
        /// </summary>
        public abstract double GetArea();

        /// <summary>
        /// Вывести информацию о фигуре
        /// </summary>
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Цвет фигуры: {_figureColor}\nВидимость: {IsVisible}\nКоординаты: ({CoordinateX}, {CoordinateY})");
        }
        #endregion
    }
}