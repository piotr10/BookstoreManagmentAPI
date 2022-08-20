using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Infrastructure.EternalAPI.GoogleBooksAPI;
using BookstoreManagement.Infrastructure.FileStore;
using BookstoreManagement.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace BookstoreManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient("GoogleBooksClient", options =>
        {
            options.BaseAddress = new Uri("https://books.google.com");
            options.Timeout = new TimeSpan(0, 0, 10);
            options.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }).ConfigurePrimaryHttpMessageHandler(sp => new HttpClientHandler());

        services.AddScoped<IGoogleBooksClient, GoogleBooksClient>();

        services.AddTransient<IDateTime, DateTimeService>();
        services.AddTransient<IDirectoryWrapper, DirectoryWrapper>();
        services.AddTransient<IFileStore, FileStore.FileStore>();
        services.AddTransient<IFileWrapper, FileWrapper>();
        return services;
    }
}