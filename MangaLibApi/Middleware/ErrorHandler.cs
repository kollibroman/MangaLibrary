namespace MangaLibApi.Middleware
{
    public class ErrorHandler : IMiddleware
    {
        private readonly ILogger<ErrorHandler> _logger;
        public ErrorHandler(ILogger<ErrorHandler> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch(Exception e)
            {
                _logger.LogError(e, e.Message);

                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("DUPA DUPA DUPA, sum ting wong");
            }
        }
    }
}