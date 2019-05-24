namespace BugRepro
{
    using BugRepro.Logging;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Logging;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging(lb =>
            {
                lb.ClearProviders();
                lb.AddProvider(new TestLoggerProvider());
            })
            .UseStartup<Startup>();
    }
}
