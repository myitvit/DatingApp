using API.Interfaces;
using API.Services;
using API.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using API.Helpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITokenService, TokenService>();

            services.AddScoped<IUserRepository, UserRepository>();

            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

            services.AddDbContext<DataContext>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}