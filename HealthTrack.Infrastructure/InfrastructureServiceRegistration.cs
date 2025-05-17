using DotNetEnv;
using HealthTrack.Core.Interfaces;
using HealthTrack.Infrastructure.Data;
using HealthTrack.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HealthTrack.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            Env.TraversePath().Load();

            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");
            if ( connectionString is null)
            {
                throw new Exception("connection cannot be null");
            }

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}
