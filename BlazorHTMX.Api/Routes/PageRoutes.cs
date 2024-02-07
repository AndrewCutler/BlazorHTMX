using BlazorHTMX.Api.Handlers;

namespace BlazorHTMX.Api.Routes
{
    public static class PageRoutes
    {
        public static WebApplication MapPageRoutes(this WebApplication app)
        {
            app.MapGet("/", new IndexHandler().Render);
            //app.MapPost("/form", async (context) =>
            //{
            //    await new CreateProtocolFormHandler().Submit(context, 1);
            //});
            app.MapPost("/form", async (context) =>
            {
                await new CreateProtocolFormHandler().Submit(context);
            });

            return app;
        }
    }
}
