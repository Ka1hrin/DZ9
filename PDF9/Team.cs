using System;
using System.Collections.Generic;

namespace PDF9
{
    internal class Team
    {
        private string _name;
        private Countries _country;
        public int PlayersCount { get; } = 15;
        private int _score;

        public Team(string name, Countries country)
        {
            Name = name;
            Country = country;
            Score = 0;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Строка не может быть пустой!");

                _name = value;
            }
        }
        public Countries Country
        {
            get { return _country; }
            set
            {
                if (!Enum.IsDefined(typeof(Countries), value))
                    throw new ArgumentException("Неизвестная страна!");

                _country = value;
            }
        }
        public int Score
        {
            get { return _score; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество баллов не может быть отрицательным!");

                _score = value;
            }
        }
    }
}
