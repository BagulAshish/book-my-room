using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PropertyService.Infrastructure.Persistence;

namespace PropertyService.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<PropertyDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("PropertyDb")));
        return services;
    }
}