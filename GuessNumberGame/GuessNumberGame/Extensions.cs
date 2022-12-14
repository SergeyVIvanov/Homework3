using Microsoft.Extensions.DependencyInjection;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame;

public static class Extensions
{
    public static IServiceCollection AddGuessNumberGame(this IServiceCollection services)
    {
        return services.AddTransient<IGame, Game>();
    }
}
