using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Sample.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("https://*:8080")
                .UseStartup<Startup>()
                .ConfigureKestrel((context, options) => {
                    // "call ConfigureKestrel to configure Kestrel server instead of UseKestrel in order to avoid conflicts with the IIS in-process hosting model"
                    // https://docs.microsoft.com/en-us/aspnet/core/migration/21-to-22?view=aspnetcore-2.2&tabs=visual-studio#update-kestrel-configuration
                });
    }
}
