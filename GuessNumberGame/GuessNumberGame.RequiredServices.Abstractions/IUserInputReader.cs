namespace GuessNumberGame.RequiredServices.Abstractions;

public interface IUserInputReader
{
    int? Read(int attemptNumber, int maxAttemptCount);
}
