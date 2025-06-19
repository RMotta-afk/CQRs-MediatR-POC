using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CQRs.MediatR.POC.Infra.Repositories.Users;
using CQRs.MediatR.POC.Domain.Users.Repositories;


public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        //DbContext register (EF Core)
        //services.AddDbContext<AppDbContext>(options =>
        //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Repo registers
        services.AddScoped<IUsersRepository, UsersRepository>();

        return services;
    }
}