using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using MyPortfolio.MessageApi.Services;
using System.Reflection;

namespace MyPortfolio.MessageApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServiceExtensions(this IServiceCollection services)
        {
            services.AddScoped<IMessageService,MessageService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
