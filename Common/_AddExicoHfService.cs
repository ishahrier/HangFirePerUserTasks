using Hangfire;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exico.HangFire.Common
{
    public static class _AddExicoHfService
    {
        public static void AddExicoHfService(this IServiceCollection services )
        {
            services.AddScoped<IFireAndForgetTaskOptions, FireAndForgetTaskOptions>();
            services.AddScoped<IScheduledTaskOptions, ScheduledTaskOptions>();
            GlobalJobFilters.Filters.Add(new ExicoHfFilter());

        }
    }
}
