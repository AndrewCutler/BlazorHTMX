using Microsoft.AspNetCore.Http.HttpResults;

namespace BlazorHTMX.Api.Handlers
{
    public class IndexHandler
    {
        public IResult Render()
        {
            return new RazorComponentResult<_Index>(new
            {
                UserName = "test",
            });
        }
    }
}
