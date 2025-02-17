using FansVoice.Shared.Middleware;
using Microsoft.AspNetCore.Builder;

namespace FansVoice.Shared.Extensions;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UseSharedMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionHandlingMiddleware>();
        return app;
    }

    public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "FansVoice API V1");
            c.RoutePrefix = string.Empty;
        });

        return app;
    }
}