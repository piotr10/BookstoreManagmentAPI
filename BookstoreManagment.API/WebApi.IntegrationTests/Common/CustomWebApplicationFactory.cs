using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Persistance;
using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Serilog;
using WebApi.IntegrationTests.Common.DummyServices;

namespace WebApi.IntegrationTests.Common;

public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        try
        {
            builder.ConfigureServices(services =>
                {
                    var serviceProvider = new ServiceCollection()
                        .AddEntityFrameworkInMemoryDatabase()
                        .BuildServiceProvider();

                    services.AddDbContext<BookstoreDbContext>(options =>
                    {
                        options.UseInMemoryDatabase("InMemoryDbForTesting");
                        options.UseInternalServiceProvider(serviceProvider);
                    });

                    services.AddScoped<IBookstoreDbContext>(provider => provider.GetService<BookstoreDbContext>());
                    services.AddScoped<ICurrentUserService, DummyCurrentUserService>();
                    var sp = services.BuildServiceProvider();

                    using var scope = sp.CreateScope();
                    var scopedServices = scope.ServiceProvider;
                    var context = scopedServices.GetRequiredService<BookstoreDbContext>();
                    var logger = scopedServices.GetRequiredService<ILogger<CustomWebApplicationFactory<TStartup>>>();

                    context.Database.EnsureCreated();

                    try
                    {
                        Utilities.InitilizeDbForTests(context);
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, "An error occurred seeding the " +
                                            $"database with test messages. Error: {ex.Message}");
                    }
                })
                .UseEnvironment("Test");
        }
        catch (Exception ex)
        {

            throw;
        }

        builder.UseSerilog();
    }

    public async Task<HttpClient> GetAuthenticatedClientAsync()
    {
        var client = CreateClient();

        var token = await GetAccessTokenAsync(client, "alice", "Pass123$");
        client.SetBearerToken(token);
        return client;
    }

    private async Task<string> GetAccessTokenAsync(HttpClient client, string userName, string password)
    {
        var disco = await client.GetDiscoveryDocumentAsync();
        
        if (disco.IsError)
        {
            throw new Exception(disco.Error);
        }
        
        var response = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
        {
            Address = disco.TokenEndpoint,
            ClientId = "client",
            ClientSecret = "secret",
            Scope = "openid profile BookstoreManagement.ApiAPI api1",
            UserName = userName,
            Password = password
        });

        if (response.IsError)
        {
            throw new Exception(response.Error);
        }

        return response.AccessToken;
    }
}