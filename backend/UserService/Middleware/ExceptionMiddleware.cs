using System.Net;

namespace Middleware
{

    public record ExcetionResponse(HttpStatusCode statusCode, string message);
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception exception)
            {
                var response = new ExcetionResponse(HttpStatusCode.InternalServerError, "Something went wrong");


                httpContext.Response.ContentType = "application/json";
                await httpContext.Response.WriteAsJsonAsync(response);
                httpContext.Response.StatusCode = (int)response.statusCode;
            }
        }
    }
}
