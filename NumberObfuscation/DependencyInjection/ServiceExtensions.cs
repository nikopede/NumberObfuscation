using Microsoft.Extensions.DependencyInjection;
using NumberObfuscation.Options;

namespace NumberObfuscation.DependencyInjection;

public static class ServiceExtensions
{
    public static void AddNumberObfuscation(this IServiceCollection services,
        Action<NumberObfuscationOptions> configureOptions)
    {
        var options = new NumberObfuscationOptions();
        configureOptions(options);
        
        services.AddSingleton(options);
        services.AddSingleton<INumberObfuscationService, NumberObfuscationService>();
    }
}