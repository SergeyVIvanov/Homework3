using GuessNumberGame.RequiredServices.Abstractions;

namespace ConsoleApp.GuessNumberGame.RequiredServices.Implementations;

public class RandomNumberGenerator : IRandomNumberGenerator
{
    int IRandomNumberGenerator.Get(int min, int max)
    {
        return Random.Shared.Next(min, max + 1);
    }
}
