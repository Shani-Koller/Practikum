using _2_SERVICES.Interfaces;
using _2_SERVICES.Services;
using _3_REPOSITORY;
using _3_REPOSITORY.Interfaces;
using _3_REPOSITORY.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace _2_SERVICES
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddDbContext<IDataSource, DataSource>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IChildService, ChildService>();
            return services;
        }
    }
}