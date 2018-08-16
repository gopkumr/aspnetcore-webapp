using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace ShopASucculent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .ConfigureAppConfiguration(configBuilder => configBuilder.AddJsonFile("appsettings.json"))
                   .ConfigureAppConfiguration(q => q.AddEnvironmentVariables())
                   .UseStartup<Startup>();
    }
}
