using BookstoreManagement.Application;
using BookstoreManagement.Infrastructure;
using BookstoreManagement.Persistance;
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
    options.AddPolicy(name: "MyAllowSpecificOrigins", // t� nazw� wklejamy do endpointu czyli controllera, kt�ry ma by� przekazany do innego origin
        builder =>
        {
            builder.WithOrigins("https://localhost:example"); //podajemy port (np. 11223) drugiego origin, kt�ry b�dzie potrzebny do po��czenia CORS mi�dzy dwoma aplikacjami
        }));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
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
}
);

builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //builder.Services.AddInfrastructure(app.Configuration);
    //builder.Services.AddPersistance(app.Configuration);
}

app.UseSwagger();

app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bookstore Management"));

app.UseHealthChecks("/hc");

app.UseHttpsRedirection();

app.UseSerilogRequestLogging();

app.UseRouting();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
