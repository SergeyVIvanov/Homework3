namespace GuessNumberGame.RequiredServices.Abstractions;

public interface IGameOutputWriter
{
    void WriteFinalResult(bool isWin);
    void WriteIntermediateResult(bool isLess);
}
