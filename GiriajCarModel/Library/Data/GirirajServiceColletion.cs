using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    public static class GirirajServiceColletion
    {
        public static void AddGirirajDbContext(this IServiceCollection services,string connectionString)
        {
            services.AddDbContext<GirirajDbContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        }

        public static void AddEntityRepositoryService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IEntityRepository<>),typeof(EntityRepository<>));
        }
    }
}