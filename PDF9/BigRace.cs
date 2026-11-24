using System;
using System.Collections.Generic;

namespace PDF9
{
    internal class BigRace
    {
        public string Name { get; } = "Телепередача 'Большие гонки'";
        public List<Team> Teams { get; set; }
        public List<IGame> Games {  get; set; }
        private Random Random = new Random();

        public BigRace()
        {
            Teams = new List<Team>();
            Games = new List<IGame>();
        }

        /// <summary>
        /// Добавить команду в лист
        /// </summary>
        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        /// <summary>
        /// Добавить игру, реализующую интерфейс в лист
        /// </summary>
        public void AddGame(IGame game)
        {
            Games.Add(game);
        }

        /// <summary>
        /// Начисление баллов командам после игры
        /// </summary>
        public void GetScore()
        {
            int[] score = [1, 2, 3, 4];

            for (int i = score.Length - 1; i > 0; i--)
            {
                int j = Random.Next(i + 1);
                int item = score[i];
                score[i] = score[j];
                score[j] = item;
            }

            for (int i = 0; i < Teams.Count; i++)
            {
                int resultScore = score[i];
                Teams[i].Score += resultScore;
                Console.WriteLine($"Команда {Teams[i].Name} получает {resultScore} очков!");
            }
        }

        /// <summary>
        /// Начать гонку
        /// </summary>
        public void StartRace()
        {
            Console.WriteLine("Да начнется гонка!");

            foreach (IGame game in Games)
            {
                foreach (var team in Teams)
                {
                    game.Play(team, Random);
                }
                GetScore();
                Console.WriteLine();
            }

            Console.WriteLine("Основные испытания подошли к концу, поэтому мы переходим к финальной битве!");
        }

        /// <summary>
        /// Метод, который определяет победителя гонки
        /// </summary>
        public Team? DetermineWinner()
        {
            if (Teams.Count == 0)
                return null;

            int totalScore = 0;
            foreach (var team in Teams)
            {
                totalScore += team.Score;
            }

            if (totalScore == 0)
                return null;

            int randomNumber = Random.Next(1, totalScore + 1);

            int section = 0;
            foreach (var team in  Teams)
            {
                section += team.Score;
                if (randomNumber <= section)
                {
                    Console.WriteLine("Победитель гонки определен!");
                    return team;
                }
            }
            return null;
        }

        public void FinalRace()
        {
            Console.WriteLine($"Дорогие дамы и господа! Вот мы и добрались до долгожданного финального испытания, которое решит исход всей гонки! " +
                $"Перед началом, давайте узнаем итоговое количество баллов, набранное каждой командой!\n");
            foreach (var team in Teams)
            {
                Console.WriteLine($"{EnumName.CountryName(team.Country)}: {team.Score}");
            }

            Console.WriteLine("\nКоличество баллов определит, насколько шагов ближе к финишу будет находиться команда. А теперь объявляем начало игры: на старт, внимание, марш!");
            Team? winner = DetermineWinner();

            if (winner is not null)
                Console.WriteLine($"С небольшим отрывом первое место занимает команда {winner.Name}!");
            else
                Console.WriteLine("Победитель не определен.");

        }

    }
}
