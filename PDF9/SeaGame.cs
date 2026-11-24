using System;

namespace PDF9
{
    internal class SeaGame : IGame
    {
        public string Name { get; } = "Море";

        public void Play(Team team, Random random)
        {
            string[] phrases =
            [
                $"Сборная {team.Name} пытается удержаться на качающемся плоту во время шторма!",
                $"Команда {team.Name} гребет изо всех сил на резиновой лодке, но весла постоянно выскальзывают.",
                $"Игроки команды {team.Name} ныряют за жемчужинами, задерживая дыхание как можно дольше."
            ];

            int randomIndex = random.Next(phrases.Length);
            Console.WriteLine($"{phrases[randomIndex]} Для команды {team.Name} игра {Name} окончена.\n");
        }
    }
}
