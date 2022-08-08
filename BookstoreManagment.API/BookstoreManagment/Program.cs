using BookstoreManagment.Infrastructure;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

//origins/policy/cors
builder.Services.AddCors(options =>
        options.AddPolicy(name: "MyAllowSpecificOrigins", // t¹ nazwê wklejamy do endpointu czyli controllera, który ma byæ przekazany do innego origin
    builder =>
    {
        builder.WithOrigins("https://localhost:example"); //podajemy port (np. 11223) drugiego origin, który bêdzie potrzebny do po³¹czenia CORS miêdzy dwoma aplikacjami
    }));

// Add services to the container.
builder.Services.AddControllers();

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
    builder.Services.AddInfrastructure(app.Configuration);
}

app.UseHealthChecks("/hc");

app.UseSwagger();

app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bookstore Management"));

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
