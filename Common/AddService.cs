using Hangfire; 
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Exico.HangFire.Common
{
    public static class AddService
    {
        public static void AddExicoHfExtension(this IServiceCollection services )
        {
            services.AddScoped<IFireAndForgetTaskOptions, FireAndForgetTaskOptions>();
            services.AddScoped<IScheduledTaskOptions, ScheduledTaskOptions>();
            GlobalJobFilters.Filters.Add(new ExicoHfFilter());

        }
    }
}
