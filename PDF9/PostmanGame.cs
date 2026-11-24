using System;

namespace PDF9
{
    internal class PostmanGame : IGame
    {
        public string Name { get; } = "Почтальон";

        public void Play(Team team, Random random)
        {
            string[] phrases =
            [
                $"Команда {team.Name} должна доставить письмо, пробираясь через болото с пиявками!",
                $"Участники команды {team.Name} сортируют гору писем на скорость, но ветер уже разносит их по улице!",
                $"Команда {team.Name} едет на старом велосипеде с тяжелой сумкой почтальона и пытается не упасть."
            ];

            int randomIndex = random.Next(phrases.Length);
            Console.WriteLine($"{phrases[randomIndex]} Для команды {team.Name} игра {Name} окончена.\n");
        }
    }
}
