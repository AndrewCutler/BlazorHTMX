using BlazorHTMX.Api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BlazorHTMX.Api.Handlers
{
    public class CreateProtocolFormHandler : IFormHandler<CreateProtocolFormModel>
    {
        public bool IsValid()
        {
            return true;
        }

        public async Task<IResult> Submit(HttpContext context)
        {
            var form = await context.Request.ReadFormAsync();
            var name = form["name"];
            Console.WriteLine(context);
            if (!IsValid())
            {
                return new RazorComponentResult<_CreateProtocolForm>()
                {
                    StatusCode = 400,
                };
            }

            // todo: return html result of created protocol
            return new RazorComponentResult<_CreateProtocolForm>();
        }
    }
}
