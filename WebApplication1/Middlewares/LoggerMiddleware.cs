using System.Diagnostics;

namespace WebApplication1.Middlewares
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        private readonly ILogger<LoggerMiddleware> logger;

        public LoggerMiddleware(RequestDelegate requestDelegate, ILogger<LoggerMiddleware> logger)
        {
            this.requestDelegate = requestDelegate;
            this.logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            logger.LogInformation("Handling reqesut: {mehtod} {url}", context.Request.Method, context.Request.Path);
            var stopwach = Stopwatch.StartNew();

            await requestDelegate(context);
            logger.LogInformation("Finished handling request. Status code: {statusCode}. Time taken {elapsedMiliseconds} ms", context.Response.StatusCode, stopwach.ElapsedMilliseconds);
        }
    }
}
