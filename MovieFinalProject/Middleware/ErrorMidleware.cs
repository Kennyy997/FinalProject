using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class NotFoundMiddleware
{
    private readonly RequestDelegate _next;

    public NotFoundMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        await _next(context);

        if (context.Response.StatusCode == 404 && !context.Response.HasStarted)
        {
            context.Response.Redirect("/Error/404");
        }
    }
}

// Middleware üçün extension method
public static class NotFoundMiddlewareExtensions
{
    public static IApplicationBuilder UseNotFoundPage(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<NotFoundMiddleware>();
    }
}
