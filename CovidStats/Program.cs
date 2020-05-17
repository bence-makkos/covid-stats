using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CovidStats
{
    class Program
    {
        static void Main()
        {
             // Create service collection and configure our services
            var services = ConfigureServices()
                .AddLogging(builder => builder.ClearProviders());

            var serviceProvider = services.BuildServiceProvider();
            // Kick off our actual code
            serviceProvider.GetService<ConsoleApplication>().Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var services = new ServiceCollection()
                .Configure<ApplicationOptions>(config.GetSection("ApplicationOptions"))
                .AddSingleton<IRecordProvider, RecordProvider>()
                .AddSingleton<ConsoleApplication>();

            return services;
        }
    }
}
