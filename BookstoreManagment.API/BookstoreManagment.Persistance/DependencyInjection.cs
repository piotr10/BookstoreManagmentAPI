using BookstoreManagement.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookstoreManagement.Persistance;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BookstoreDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("BookstoreDatabase5")));
        services.AddScoped<IBookstoreDbContext, BookstoreDbContext>();
        return services;
    }
}