using System;

namespace PDF9
{
    internal class FishinfGame : IGame
    {
        public string Name { get; } = "Рыбалка";

        public void Play(Team team, Random random)
        {
            string[] phrases =
            [
                $"Команда {team.Name} закидывает удочки, но вместо рыбы вытаскивает старый ржавый сапог.",
                $"Участники команды {team.Name} пытаются поймать гигантского сома голыми руками в мутной воде!",
                $"Сборная {team.Name} соревнуется в скоростной чистке рыбы, чешуя летит во все стороны!"
            ];

            int randomIndex = random.Next(phrases.Length);
            Console.WriteLine($"{phrases[randomIndex]} Для команды {team.Name} игра {Name} окончена.\n");
        }
    }
}
