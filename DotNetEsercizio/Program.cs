using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace DotNetEsercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = ConfigureServices();

            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<App>().Run();
        }
        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            //Add custom services
            services.AddSingleton<App>();
            services.AddSingleton<IRandomGenerator,RandomGenerator>();
            return services;
        }
    }
}
