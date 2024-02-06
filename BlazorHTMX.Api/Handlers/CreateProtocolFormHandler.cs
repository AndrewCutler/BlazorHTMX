using Microsoft.AspNetCore.Http.HttpResults;

namespace BlazorHTMX.Api.Handlers
{
    public class CreateProtocolFormHandler : IFormHandler
    {
        public bool IsValid()
        {
            return true;
        }

        public IResult Submit()
        {
            if (IsValid())
            {
                return new RazorComponentResult<_CreateProtocolForm>()
                {
                    StatusCode = 400,
                };
            }

            return new RazorComponentResult<_CreateProtocolForm>();
        }
    }
}
