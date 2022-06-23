using System.Net;
using System.Text.Json;

namespace API
{
    public class ErrorHandlerMW
    {
        private readonly RequestDelegate next;

        public ErrorHandlerMW(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext ctx)
        {
            try
            {
                await next(ctx);
            }
            catch (Exception exc)
            {
                var response = ctx.Response;
                response.ContentType = "application/json";

                response.StatusCode = exc switch
                {
                    KeyNotFoundException => (int)HttpStatusCode.NotFound,
                    _ => (int)HttpStatusCode.InternalServerError,
                };

                var result = JsonSerializer.Serialize(new { message = exc.Message });
                await response.WriteAsync(result);
            }
        }
    }
}
