using Microsoft.EntityFrameworkCore;
using Project.Api.Core.Application.Repositories;
using Project.Api.Core.Application.Services;
using Project.Api.Infrastructure.Persistence.Contexts;
using Project.Api.Infrastructure.Persistence.Repositories;
using Project.Api.Infrastructure.Persistence.Services;

namespace Project.Api.Infrastructure.Persistence;

public static class PersistenceServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ProjectDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("ProjectDb"));
        });

        services.AddScoped(typeof(ICustomerRepository), typeof(CustomerRepository));
        services.AddScoped(typeof(ICustomerTypeRepository), typeof(CustomerTypeRepository));

        services.AddScoped(typeof(ICustomerService), typeof(CustomerService));
        services.AddScoped(typeof(ICustomerTypeService), typeof(CustomerTypeService));
    }
}
