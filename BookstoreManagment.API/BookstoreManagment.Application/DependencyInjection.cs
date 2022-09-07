using System.Reflection;
using BookstoreManagement.Application.Common.Behaviours;
using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.DependencyInjection;

namespace BookstoreManagement.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddTransient(typeof(IRequestPreProcessor<>), typeof(LoggingBehaviour<>));
        return services;
    }
}