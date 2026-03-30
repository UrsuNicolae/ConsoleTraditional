namespace WebApplication1.Middlewares
{
    public class HeaderCheckerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly string headerName;

        public HeaderCheckerMiddleware(RequestDelegate next, string headerName)
        {
            this.next = next;
            this.headerName = headerName;
        }

        public async Task Invoke(HttpContext context)
        {
            if (!context.Request.Headers.ContainsKey(headerName))
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync($"Missing required header:{headerName}");
                return;
            }
            await next(context);
        }
    }
}
