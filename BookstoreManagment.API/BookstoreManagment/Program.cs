using System.Reflection;
using System.Security.Claims;
using BookstoreManagement.Api;
using BookstoreManagement.Api.Service;
using BookstoreManagement.Application;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Infrastructure;
using BookstoreManagement.Infrastructure.Identity;
using BookstoreManagement.Persistance;
using BookstoreManagment.Api;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Test;
using IdentityModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using IdentityServer4;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

var builder = WebApplication.CreateBuilder(args);

//Serilog
try
{
    Log.Information("Application is starting up.");
}
catch (Exception e)
{
    Log.Fatal(e, "Could not start up application.");
    throw;
}
finally
{
    Log.CloseAndFlush();
}

builder.Host.UseSerilog((ctx, cfg) => cfg.ReadFrom.Configuration(ctx.Configuration));

// Add services to the container.
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddPersistance(builder.Configuration);
builder.Services.AddControllers();

//origins/policy/cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin());
});   // t¹ nazwê wklejamy do endpointu czyli controllera, który ma byæ przekazany do innego origin

#region Second origin port
/*builder =>
{
    builder.WithOrigins("https://localhost:example"); //podajemy port (np. 11223) drugiego origin, który bêdzie potrzebny do po³¹czenia CORS miêdzy dwoma aplikacjami
}));*/
#endregion

builder.WebHost.ConfigureAppConfiguration((hostingContext, config) =>
{

    var env = hostingContext.HostingEnvironment;

    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
        .AddJsonFile($"appsettings.Local.json", optional: true, reloadOnChange: true);

    if (env.IsDevelopment())
    {
        var appAssembly = Assembly.Load(new AssemblyName(env.ApplicationName));
        config.AddUserSecrets(appAssembly, optional: true);
    }

    config.AddEnvironmentVariables();

    if (args != null)
    {
        config.AddCommandLine(args);
    }
});

if (builder.Environment.IsEnvironment("Test"))
{

    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("BookstoreDatabase5")));
    builder.Services.AddDefaultIdentity<ApplicationUser>().AddEntityFrameworkStores<ApplicationDbContext>();
    builder.Services.AddIdentityServer()
        .AddApiAuthorization<ApplicationUser, ApplicationDbContext>(options =>
        {
            options.ApiResources.Add(new ApiResource("api1"));
            options.ApiScopes.Add(new ApiScope("api1"));
            options.Clients.Add(new Client
            {
                ClientId = "client",
                AllowedGrantTypes = { GrantType.ResourceOwnerPassword },
                ClientSecrets = { new Secret("secret".Sha256()) },
                AllowedScopes = { "openid", "profile", "BookstoreManagement.ApiAPI", "api1" }
            });
        }).AddTestUsers(new List<TestUser>
        {
            new TestUser
            {
                SubjectId = "4B434A88-212D-4A4D-A17C-F35102D73CBB",
                Username = "alice",
                Password = "Pass123$",
                Claims = new List<Claim>
                {
                    new Claim(JwtClaimTypes.Email, "alice@user.com"),
                    new Claim(ClaimTypes.Name, "alice")
                }
            }
        });
    builder.Services.AddAuthentication("Bearer").AddIdentityServerJwt();
}
else
{
    builder.Services.AddAuthentication("Bearer")
        .AddJwtBearer("Bearer", options =>
        {
            options.Authority = "https://localhost:5001";
            options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            {
                ValidateAudience = false
            };
        });
    builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy("ApiScope", policy =>
        {
            policy.RequireAuthenticatedUser();
            policy.RequireClaim("scope", "api1");
        });
    });
}

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.OAuth2,
        Flows = new OpenApiOAuthFlows
        {
            AuthorizationCode = new OpenApiOAuthFlow
            {
                AuthorizationUrl = new Uri("https://localhost:5001/connect/authorize"),
                TokenUrl = new Uri("https://localhost:5001/connect/token"),
                Scopes = new Dictionary<string, string>
                {
                    {"api1", "Full access" },
                    {"user", "User info" },
                    {"openid", "Open Id" }
                }
            }
        }
    });
    c.OperationFilter<AuthorizeCheckOperationFilter>();
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Bookstore Management",
        Version = "v1",
        Description = "A simple web application for management bookstore",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Piotr",
            Email = string.Empty,
            Url = new Uri("https://piotr-example.com")
        },
        License = new OpenApiLicense
        {
            Name = "Used License",
            Url = new Uri("https://example.com/license")
        }
    });
    var filePath = Path.Combine(AppContext.BaseDirectory, "BookstoreManagement.Api.xml");
    c.IncludeXmlComments(filePath);
});

builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.TryAddScoped(typeof(ICurrentUserService), typeof(CurrentUserService));
builder.Services.AddHealthChecks();

var app = builder.Build();
IWebHostEnvironment env = app.Environment;
// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bookstore Management");
        c.OAuthClientId("swagger");
        c.OAuth2RedirectUrl("https://localhost:44312/swagger/oauth2-redirect.html");
        c.OAuthUsePkce();//another safeguard for our website
    });
}

app.UseHealthChecks("/hc");

app.UseHttpsRedirection();

app.UseAuthentication();

if (app.Environment.IsEnvironment("Test"))
{
    app.UseIdentityServer();
}

app.UseSerilogRequestLogging();

app.UseRouting();

app.UseCors();

app.UseAuthorization();

app.MapControllers().RequireAuthorization("ApiScope");

app.Run();

public partial class Program { }