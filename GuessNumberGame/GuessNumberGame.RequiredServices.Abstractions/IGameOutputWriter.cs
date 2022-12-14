using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.RequiredServices.Abstractions;

public interface IGameOutputWriter
{
    void WriteFinalResult(bool isWin);
    void WriteIntermediateResult(bool isLess);
}
