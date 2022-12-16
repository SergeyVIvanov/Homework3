using GuessNumberGame.RequiredServices.Abstractions;
using Services.Abstractions;

namespace GuessNumberGame;

public class Game : IGame
{
    private readonly IGameOutputWriter _gameOutputWriter;
    private readonly IRandomNumberGenerator _randomNumberGenerator;
    private readonly IUserInputReader _userInputReader;

    private readonly int _maxAttemptCount;
    private readonly int _rangeMax;
    private readonly int _rangeMin;

    public Game(ISettingProvider settingsProvider, IRandomNumberGenerator randomNumberGenerator,
        IUserInputReader userInputReader, IGameOutputWriter gameOutputWriter)
    {
        (_maxAttemptCount, _rangeMax, _rangeMin) = (settingsProvider.MaxAttemptCount, settingsProvider.RangeMax, settingsProvider.RangeMin);
        (_randomNumberGenerator, _userInputReader, _gameOutputWriter) = (randomNumberGenerator, userInputReader, gameOutputWriter);
    }

    public void Start()
    {
        int number = _randomNumberGenerator.Get(_rangeMin, _rangeMax);

        for (int i = 0; i < _maxAttemptCount; i++)
        {
            int? candidate = _userInputReader.Read(i + 1, _maxAttemptCount);

            if (candidate == null)
                return;

            if (candidate == number)
            {
                _gameOutputWriter.WriteFinalResult(true);
                return;
            }

            _gameOutputWriter.WriteIntermediateResult(candidate < number);
        }

        _gameOutputWriter.WriteFinalResult(false);
    }
}
