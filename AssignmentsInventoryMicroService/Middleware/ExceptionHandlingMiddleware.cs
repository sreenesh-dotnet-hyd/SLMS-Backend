using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace AssignmentsInventoryMicroService.Middleware
{
    /// <summary>
    /// Global exception handling middleware that returns RFC 7807 ProblemDetails JSON.
    /// </summary>
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                // Log full exception to console / configured logger
                _logger.LogError(ex, "Unhandled exception for request {Path}", context.Request.Path);

                // Build ProblemDetails-style response (RFC 7807)
                var statusCode = (int)HttpStatusCode.InternalServerError;

                var problem = new
                {
                    type = "https://httpstatuses.com/500",
                    title = "An unexpected error occurred.",
                    status = statusCode,
                    traceId = context.TraceIdentifier
                    // NOTE: we do NOT expose ex.Message / stacktrace here (production-safe)
                };

                context.Response.StatusCode = statusCode;
                context.Response.ContentType = "application/json";

                var json = JsonSerializer.Serialize(problem);
                await context.Response.WriteAsync(json);
            }
        }
    }

    public static class ExceptionHandlingMiddlewareExtensions
    {
        /// <summary>
        /// Extension method to add the global exception handling middleware.
        /// </summary>
        public static IApplicationBuilder UseGlobalExceptionHandling(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
