using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.RequiredServices.Abstractions;

public interface ISettingProvider
{
    int MaxAttemptCount { get; }
    int RangeMax { get; }
    int RangeMin { get; }
}
