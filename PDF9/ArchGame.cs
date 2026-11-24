using System;

namespace PDF9
{
    internal class ArchGame : IGame
    {
        public string Name { get; } = "Арки";

        public void Play(Team team, Random random)
        {
            string[] phrases =
            [
                $"Команда {team.Name} строит хрупкие арки, но разъяренный бык уже разбегается для атаки!",
                $"Сборная {team.Name} пытается заманить быка в арку, но он в ярости бросается на строителей!",
                $"Команда {team.Name} построила идеальную арку, но бык решил, что она слишком красивая, и сломал её!"
            ];

            int randomIndex = random.Next(phrases.Length);
            Console.WriteLine($"{phrases[randomIndex]} Для команды {team.Name} игра {Name} окончена.\n");
        }
    }
}
