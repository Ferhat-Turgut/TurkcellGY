using Microsoft.EntityFrameworkCore;
using Survey.Infrastructure;
using SurveyApp.Infrastructure.Repositories;
using SurveyApp.Services;
using SurveyApp.Services.Mapping;

namespace SurveyApp.API.Extensions
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddInjections(this IServiceCollection services, string connectionString)
        {

            services.AddScoped<ISurveyService, SurveyService>();
            services.AddScoped<ISurveyRepository, EFSurveyRepository>();
            services.AddAutoMapper(typeof(MapProfile));
            //IoC
            services.AddDbContext<SurveyDbContext>(opt => opt.UseSqlServer(connectionString));

            return services;
        }
    }
}
