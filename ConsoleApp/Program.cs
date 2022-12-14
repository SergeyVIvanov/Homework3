using ConsoleApp.GuessNumberGame.RequiredServices.Implementations;
using GuessNumberGame;
using GuessNumberGame.RequiredServices.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Abstractions;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) => services
        .AddTransient<IGameOutputWriter, GameInputOutputConsole>()
        .AddTransient<IRandomNumberGenerator, RandomNumberGenerator>()
        .AddTransient<ISettingProvider, SettingProvider>()
        .AddTransient<IGame, Game>())
    .Build();

RunGame(host.Services);

await host.RunAsync();

static void RunGame(IServiceProvider services)
{
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    services.GetRequiredService<IGame>().Start();
}