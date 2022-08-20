using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Infrastructure.FileStore;
using BookstoreManagement.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace BookstoreManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IDateTime, DateTimeService>();
        services.AddTransient<IDirectoryWrapper, DirectoryWrapper>();
        services.AddTransient<IFileStore, FileStore.FileStore>();
        services.AddTransient<IFileWrapper, FileWrapper>();
        return services;
    }
}