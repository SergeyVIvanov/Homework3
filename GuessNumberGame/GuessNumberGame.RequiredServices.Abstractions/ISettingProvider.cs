namespace GuessNumberGame.RequiredServices.Abstractions;

public interface ISettingProvider
{
    int MaxAttemptCount { get; }
    int RangeMax { get; }
    int RangeMin { get; }
}
