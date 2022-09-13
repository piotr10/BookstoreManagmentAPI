using BookstoreManagement.Api.Service;
using BookstoreManagement.Application;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Infrastructure;
using BookstoreManagement.Persistance;
using BookstoreManagment.Api;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;

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
                    {"api1", "Demo - full access" }
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

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //builder.Services.AddInfrastructure(app.Configuration);
    //builder.Services.AddPersistance(app.Configuration);
}

app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bookstore Management");
    c.OAuthClientId("swagger");
    c.OAuth2RedirectUrl("https://localhost:44312/swagger/oauth2-redirect.html");
    c.OAuthUsePkce();//another safeguard for our website
});
app.UseHealthChecks("/hc");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseSerilogRequestLogging();

app.UseRouting();

app.UseCors();

app.UseAuthorization();
/*
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});*/
app.MapControllers().RequireAuthorization("ApiScope");

app.Run();
