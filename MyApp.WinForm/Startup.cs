using Microsoft.Extensions.DependencyInjection;
using MyApp.Services.Domain.Interfaces;
using MyApp.Services.Domain.Implementations;
using MyApp.Data;

public class Startup
{
    public static ServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        // Register your services here
        services.AddSingleton<IDataAccess, DataAccess>();
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IActionLogService, ActionLogService>();

        return services.BuildServiceProvider();
    }
}
