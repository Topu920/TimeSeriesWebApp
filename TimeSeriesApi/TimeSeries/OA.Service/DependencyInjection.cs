using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddTransient<IBuildingService, BuildingService>();
            services.AddTransient<IObjectService, ObjectService>();
            services.AddTransient<IDataFieldService, DataFieldService>();
            services.AddTransient<IReadingService, ReadingService>();
            return services;
        }
    }
}
