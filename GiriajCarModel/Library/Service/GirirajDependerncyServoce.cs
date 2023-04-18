using System;
using Microsoft.Extensions.DependencyInjection;

namespace Service
{
    public static class GirirajDependerncyServoce
    {
        public static void AddCarService(this IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
        }
    }
}

