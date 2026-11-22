using System;

namespace DZ9
{
    public class Help
    {
        public static string ReadString(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(str))
                throw new ArgumentException("Вы ввели пустую строку!");

            return str;
        }

        public static double ReadDouble(string prompt)
        {
            Console.Write(prompt);
            if (!double.TryParse(Console.ReadLine(), out var value))
                throw new ArgumentException("Вы ввели некорректное значение!");
            return value;
        }
    }
}