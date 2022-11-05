using API.Interfaces;
using API.Services;
using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITokenService, TokenService>();

            services.AddDbContext<DataContext>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}