using MarketInvoice.CTE.Services.LoanService;
using Microsoft.Extensions.DependencyInjection;

namespace MarketInvoice.CTE.Api.Extensions
{
    public static class StartupExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ILoanService, LoanService>();
        }
    }
}
