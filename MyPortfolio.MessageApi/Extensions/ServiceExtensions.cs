using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using MyPortfolio.ContactApi.Services.ContactServices;
using MyPortfolio.MessageApi.Services.MessageServices;
using System.Reflection;

namespace MyPortfolio.MessageApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServiceExtensions(this IServiceCollection services)
        {
            services.AddScoped<IMessageService,MessageService>();
            services.AddScoped<IContactService,ContactService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
