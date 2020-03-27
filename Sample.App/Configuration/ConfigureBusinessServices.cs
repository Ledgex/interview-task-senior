using Microsoft.Extensions.DependencyInjection;
using Sample.App.BusinessServices.Services.TransactionService;

namespace Sample.App.Configuration
{
    public static class ConfigureBusinessServices
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IMarketValueService, MarketValueService>();
        }
    }
}
