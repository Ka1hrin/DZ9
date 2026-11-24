using System;

namespace PDF9
{
    internal class SlideGame : IGame
    {
        public string Name { get; } = "Горки";

        public void Play(Team team, Random random)
        {
            string[] phrases =
            [
                $"Сборная {team.Name} скатывается с ледяной горки на скорость, пытаясь не врезаться в сугроб!",
                $"Участники команды {team.Name} поднимаются в гору с тяжелым рюкзаком, но их постоянно сдувает ветром.",
                $"Игроки команды {team.Name} съезжают с водной горки, пытаясь удержать в руках поднос с напитками!"
            ];

            int randomIndex = random.Next(phrases.Length);
            Console.WriteLine($"{phrases[randomIndex]} Для команды {team.Name} игра {Name} окончена.\n");
        }
    }
}
