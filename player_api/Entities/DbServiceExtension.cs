using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.Entities
{
    public static class DbServiceExtension
    {

        public static void AddDatabaseService(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<CodeFirstDemoContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")
                ));
    }
}
