using System.Diagnostics;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BookstoreManagement.Application.Common.Behaviours;

public class PerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly ILogger<TRequest> _logger;
    private readonly Stopwatch _timer;
    public PerformanceBehaviour(ILogger<TRequest> logger)
    {
        _timer = new Stopwatch();
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        _timer.Start();
        var response = await next();
        _timer.Stop();

        var elapsed = _timer.ElapsedMilliseconds;

        if (elapsed > 500)
        {
            var requestName = typeof(TRequest).Name;
            _logger.LogInformation("BookstoreManagement Long Running Request: {Name} ({elapsed}) {@Request}", requestName, elapsed, request);
        }

        return response;
    }
}