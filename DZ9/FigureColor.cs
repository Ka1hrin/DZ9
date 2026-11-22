using System;

namespace DZ9
{
    internal enum FigureColor
    {
        Red, Green, Blue, Yellow, Black, White
    }

    internal class RusColor
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
    }
}