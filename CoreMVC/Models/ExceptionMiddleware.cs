namespace CoreMVC.Models
{
    public class ExceptionMiddleware : IMiddleware
    {
        private readonly ILogger<ExceptionMiddleware> _logger;
        public ExceptionMiddleware(ILogger<ExceptionMiddleware> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                
                await HandleException(context, ex);
            }
        }
        public static Task HandleException(HttpContext context, Exception ex)
        {
            CustomException customException = new CustomException()
            {
                StatusCode = 500,
                Message = ex.Message
            };
            return context.Response.WriteAsJsonAsync(customException);
        }
    }
}
