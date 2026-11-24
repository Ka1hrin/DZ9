using System;

namespace DZ9
{
    internal enum FigureColor
    {
        Red, Green, Blue, Yellow, Black, White
    }

    internal class Color
    {
        public static FigureColor RusStr(string figureColor)
        {
            figureColor = figureColor.ToLower();
            switch (figureColor)
            {
                case "красный": return FigureColor.Red; 
                case "зеленый": return FigureColor.Green;
                case "голубой": return FigureColor.Blue;
                case "желтый": return FigureColor.Yellow;
                case "черный": return FigureColor.Black;
                case "белый": return FigureColor.White;
                default: throw new ArgumentException("Неизвестный цвет!");
            }
        }

        public static string RusStr(FigureColor color)
        {
            return (color) switch
            {
                FigureColor.Black => "черный",
                FigureColor.Blue => "голубой",
                FigureColor.Green => "зеленый",
                FigureColor.Red => "красный",
                FigureColor.White => "белый",
                FigureColor.Yellow => "желтый",
                _ => throw new ArgumentException("Неизвестный цвет!")
            };
        }
    }
}