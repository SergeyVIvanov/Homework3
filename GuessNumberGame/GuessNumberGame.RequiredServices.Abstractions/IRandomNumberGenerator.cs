namespace GuessNumberGame.RequiredServices.Abstractions;

public interface IRandomNumberGenerator
{
    int Get(int min, int max);
}
