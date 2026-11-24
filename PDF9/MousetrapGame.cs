using System;

namespace PDF9
{
    internal class MousetrapGame : IGame
    {
        public string Name { get; } = "Мышеловка";

        public void Play(Team team, Random random)
        {
            string[] phrases =
            [
                $"Команда {team.Name} на цыпочках пробирается через лабиринт с гигантскими мышеловками.",
                $"Сборная {team.Name} пытается вытащить кусок сыра, не задев натянутые веревки!",
                $"Участники команды {team.Name} надели костюмы мышей и пытаются спрятаться от огромного кота."
            ];

            int randomIndex = random.Next(phrases.Length);
            Console.WriteLine($"{phrases[randomIndex]} Для команды {team.Name} игра {Name} окончена.\n");
        }
    }
}
