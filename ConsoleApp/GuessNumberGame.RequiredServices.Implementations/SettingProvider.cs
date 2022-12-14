using GuessNumberGame.RequiredServices.Abstractions;

namespace ConsoleApp.GuessNumberGame.RequiredServices.Implementations;

public class SettingProvider : ISettingProvider
{
    public int MaxAttemptCount => 5;
    public int RangeMin => 1;
    public int RangeMax => 9;
}
