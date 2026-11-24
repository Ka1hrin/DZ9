using System;

namespace DZ9
{
    internal class Laba9
    {
        private static void Main()
        {
            Task();
            Homework();
        }

        private static void Task()
        {
            Console.WriteLine("Упражнение 10.1.");

            string prompt = Help.ReadString("Введите сообщение: ");
            ACipher aCipher = new ACipher();
            BCipher bCipher = new BCipher();
            string encodeA = aCipher.Encode(prompt);
            string encodeB = bCipher.Encode(prompt);
            Console.WriteLine($"1.Исходное сообщение: {prompt}\nЗащифрованное сообщение: {encodeA}\nРасшифрованное сообщение: {aCipher.Decode(encodeA)}" +
                $"\n2.Исходное сообщение: {prompt}\nЗащифрованное сообщение: {encodeB}\nРасшифрованное сообщение: {bCipher.Decode(encodeB)}");
        }

        private static void Homework()
        {
            Console.WriteLine("Домашнее задание 10.1.");

            string pointColor = Help.ReadString("Введите цвет (только основные цвета): ");
            double x = Help.ReadDouble("Введите значение координаты x: ");
            double y = Help.ReadDouble("Введите значение координаты y: ");
            double radius = Help.ReadDouble("Введите радиус: ");
            double width = Help.ReadDouble("Введите ширину прямоугольника: ");
            double height = Help.ReadDouble("Введите длину прямоугольника: ");

            Point point = new Point(Color.RusStr(pointColor), x, y);
            Circle circle = new Circle(Color.RusStr(pointColor), x, y, radius);
            Rectangle rectangle = new Rectangle(Color.RusStr(pointColor), x, y, width, height);
            Figure[] figureArray = {point, circle, rectangle};

            string newPointColor = Help.ReadString("Введите новый цвет точки: ");
            string newCircleColor = Help.ReadString("Введите новый цвет круга: ");

            point.ChangeColor(newPointColor);
            circle.ChangeColor(newCircleColor);

            circle.Hide();
            circle.Show();
            rectangle.Hide();

            double dx = Help.ReadDouble("Введите, насколько хотите сдвинуть точку по горизонтали: ");
            double dy = Help.ReadDouble("Введите, насколько хотите сдвинуть точку по вертикали: ");
            point.MoveHorizontal(dx);
            point.MoveVertical(dy);
            double dx2 = Help.ReadDouble("Введите, насколько хотите прямоугольник точку по горизонтали: ");
            double dy2 = Help.ReadDouble("Введите, насколько хотите сдвинуть прямоугольник по вертикали: ");
            rectangle.Move(dx2, dy2);

            foreach (Figure item in figureArray)
            {
                item.PrintInfo();
            }
        }
    }
}