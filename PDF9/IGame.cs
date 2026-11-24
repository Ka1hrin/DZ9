using System;

namespace PDF9
{
    internal interface IGame
    {
        //запускает игру для команды
        void Play(Team team, Random random);
    }
}
