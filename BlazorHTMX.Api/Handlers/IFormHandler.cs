using Microsoft.AspNetCore.Mvc;

namespace BlazorHTMX.Api.Handlers
{
    public interface IFormHandler<TForm>
    {
        bool IsValid();

        //IResult Submit([FromForm] object data);
        Task<IResult> Submit(HttpContext context);
    }
}
