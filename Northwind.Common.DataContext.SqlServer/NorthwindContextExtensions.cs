using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Packt.Shared
{
    public static class NorthwindContextExtensions
    {
        public static IServiceCollection AddNorthwindContext(
            this IServiceCollection services,
            string connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=true;MultipleActiveResultsets=true;Encrypt=false")
        {
            services.AddDbContext<NorthwindContext>(options =>
            {
                options.UseSqlServer(connectionString);

                options.LogTo(Console.WriteLine, new[] { Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.CommandExecuting });
            });

            return services;
        }
    }
}
