using PDF9;
using System;

namespace DZ9
{
    internal class PDF9
    {
        private static void Main()
        {
            BigRace bigRace = new BigRace();
            Team team1 = new Team("Веселые ребята", Countries.Russia);
            bigRace.AddTeam(team1);
            Team team2 = new Team("Французы", Countries.France);
            bigRace.AddTeam(team2);
            Team team3 = new Team("Казахи", Countries.Kazakhstan);
            bigRace.AddTeam(team3);
            Team team4 = new Team("Китайцы", Countries.China);
            bigRace.AddTeam(team4);

            bigRace.AddGame(new ArchGame());
            bigRace.AddGame(new BeachGame());
            bigRace.AddGame(new FishinfGame());
            bigRace.AddGame(new MousetrapGame());
            bigRace.AddGame(new PostmanGame());
            bigRace.AddGame(new SeaGame());
            bigRace.AddGame(new SlideGame());

            bigRace.StartRace();
            bigRace.FinalRace();

        }
    }
}