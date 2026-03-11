using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace GAC.API.Middleware;

internal sealed class GenericExceptionHandler
      : IExceptionHandler
{
    private readonly ILogger<GenericExceptionHandler> _logger;

    public GenericExceptionHandler(ILogger<GenericExceptionHandler> logger)
    {
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        _logger.LogError(exception, "Unhandled exception occurred");

        var (statusCode, message) = exception switch
        {
            UnauthorizedAccessException =>
                (HttpStatusCode.Unauthorized, "Authentication failed: Invalid or expired token."),

            ApplicationException { Message: string msg } when
                msg.Contains("Invalid Token", StringComparison.OrdinalIgnoreCase) =>
                (HttpStatusCode.Unauthorized, "Authentication failed: Invalid or expired token."),

            ApplicationException { Message: string msg } =>
                (HttpStatusCode.BadRequest, msg),

            HttpRequestException { StatusCode: HttpStatusCode.TooManyRequests } =>
                (HttpStatusCode.TooManyRequests, "Rate limit exceeded. Please try again later."),

            HttpRequestException { StatusCode: HttpStatusCode.ServiceUnavailable } =>
                (HttpStatusCode.ServiceUnavailable, "Service is temporarily unavailable."),

            HttpRequestException { StatusCode: HttpStatusCode.BadRequest, Message: string msg } =>
                (HttpStatusCode.BadRequest, $"Invalid request: {msg}"),

            HttpRequestException { Message: string msg } =>
                (HttpStatusCode.BadGateway, $"API request failed: {msg}"),

            TaskCanceledException =>
                (HttpStatusCode.GatewayTimeout, "Request timed out."),

            TimeoutException =>
                (HttpStatusCode.GatewayTimeout, "Request timed out."),

            OperationCanceledException =>
                (HttpStatusCode.ServiceUnavailable, "Operation was canceled."),

            ArgumentNullException { ParamName: string paramName } =>
                (HttpStatusCode.BadRequest, $"Missing required parameter: {paramName}"),

            InvalidOperationException { Message: string msg } =>
                (HttpStatusCode.BadRequest, $"Invalid operation: {msg}"),

            _ =>
                (HttpStatusCode.InternalServerError, "An unexpected error occurred.")
        };

        httpContext.Response.StatusCode = (int)statusCode;
        httpContext.Response.ContentType = "application/json";

        var response = new
        {
            success = false,
            statusCode = (int)statusCode,
            message,
            traceId = httpContext.TraceIdentifier
        };

        await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);

        return true;
    }
}