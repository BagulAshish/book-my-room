using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProfileService.Infrastructure.Persistence;

namespace ProfileService.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ProfileDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("ProfileDb")));
        return services;
    }
}