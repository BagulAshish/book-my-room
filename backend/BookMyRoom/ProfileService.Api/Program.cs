using Microsoft.EntityFrameworkCore;
using ProfileService.Api.Controllers;
using ProfileService.Application.Interfaces;
using ProfileService.Contracts.Interfaces;
using ProfileService.Infrastructure;
using ProfileService.Infrastructure.Persistence;
using ProtoBuf.Grpc.Server;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.AddCodeFirstGrpc();

builder.Services.AddScoped<IProfileService, ProfileService.Application.Services.ProfileService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", cfg =>
    {
        cfg.AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin();
    });
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ProfileDbContext>();
    db.Database.Migrate();
}

app.UseCors("AllowAll");

app.MapControllers();

app.MapGrpcService<ProfileGrpcController>();

app.Run();
    
    

