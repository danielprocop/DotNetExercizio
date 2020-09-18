using DotNetEsercizio.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace DotNetEsercizio
{
    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();

            IServiceCollection services = new ServiceCollection();
            services
                .Configure<Settings>(Configuration.GetSection(nameof(Settings)))
                .AddOptions()
            //Add custom services
                .AddSingleton<App>()
                .AddSingleton<IRandomGenerator, RandomGenerator>()
                .BuildServiceProvider();

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<App>().Run();
        }

    }
}
