using Cola.Core.ColaConsole;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.ColaMongo;

public static class ColaMongoInject
{
    public static IServiceCollection AddColaMongo(
        this IServiceCollection services)
    {
        services.AddSingleton<IColaMongo,ColaMongo>();
        ConsoleHelper.WriteInfo("AddColaMongo 注入");
        return services;
    }
}