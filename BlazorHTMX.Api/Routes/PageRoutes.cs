using BlazorHTMX.Api.Handlers;
using BlazorHTMX.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorHTMX.Api.Routes
{
    public static class PageRoutes
    {
        public static WebApplication MapPageRoutes(this WebApplication app)
        {
            app.MapGet("/", new IndexHandler().Render);

			app.MapPost("/form", ([FromForm] CreateProtocolFormModel form) =>
			{
				return new CreateProtocolFormHandler().Submit(form);
			});

			app.MapGet("/protocols", ([AsParameters] PaginationRequest<ProtocolModel> pagination) =>
			{
				return new ProtocolTableHandler().Render(pagination);
			});

			return app;
        }
    }
}
