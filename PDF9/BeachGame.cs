using System;

namespace PDF9
{
    internal class BeachGame : IGame
    {
        public string Name { get; } = "Пляж";

        public void Play(Team team, Random random)
        {
            string[] phrases =
            [
                $"Команда {team.Name} несется по горячему песку, уворачиваясь от летящих волейбольных мячей!",
                $"Сборная {team.Name} строит самую высокую песчаную башню, но прибой уже близко...",
                $"Игроки команды {team.Name} пытаются поймать скользкую рыбу руками прямо на мелководье!"
            ];

            int randomIndex = random.Next(phrases.Length);
            Console.WriteLine($"{phrases[randomIndex]} Для команды {team.Name} игра {Name} окончена.\n");
            
        }
    }
}
