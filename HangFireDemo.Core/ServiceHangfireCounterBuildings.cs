using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HangFireDemo.Core
{
    public static class ServiceHangfireCounterBuildings
    {
        public static IServiceCollection AddHangFireTrafficController(this IServiceCollection services, HangfireCounter configuration)
        {
            services.AddSingleton(configuration);
            services.AddSingleton<IHangfireCounter, HangfireCounter>();

            return services;
        }
    }
}
