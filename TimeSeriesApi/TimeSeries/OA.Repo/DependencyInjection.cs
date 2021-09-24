using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepo(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBuildingRepository<>), typeof(BuildingRepository<>));
            services.AddScoped(typeof(IObjectRepository<>), typeof(ObjectRepository<>));
            services.AddScoped(typeof(IDataFieldRepository<>), typeof(DataFieldRepository<>));
            services.AddScoped(typeof(IReadingRepository<>), typeof(ReadingRepository<>));
            return services;
        }
    }
}
