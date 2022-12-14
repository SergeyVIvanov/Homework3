using GuessNumberGame.RequiredServices.Abstractions;

namespace ConsoleApp.GuessNumberGame.RequiredServices.Implementations;

public class GameInputOutputConsole : IUserInputReader, IGameOutputWriter
{
    public int? Read(int attemptNumber, int maxAttemptCount)
    {
        int candidate = 0;
        bool terminate;

        Console.Write($"Попытка {attemptNumber}. Введите число: ");
        for (; ; )
        {
            terminate = false;
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                terminate = true;
                break;
            }
            if (int.TryParse(input, out candidate))
                break;
        }

        return terminate ? null : candidate;
    }

    public void WriteFinalResult(bool isWin)
    {
        Console.WriteLine(isWin ? "Угадали!" : "Количество попыток исчерпано. Вы проиграли.");
    }

    public void WriteIntermediateResult(bool isLess)
    {
        Console.WriteLine(isLess ? "Меньше" : "Больше");
    }
}
