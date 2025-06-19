using Microsoft.Extensions.DependencyInjection;

public static class DomainServiceRegistration
{
    public static void AddDomain(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DomainServiceRegistration).Assembly));

    }
}