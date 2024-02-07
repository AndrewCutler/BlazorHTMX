using BlazorHTMX.Api.Models;
using BlazorHTMX.Api.Pages;

namespace BlazorHTMX.Api.Handlers
{
    public class IndexHandler
    {
        public IResult Render()
        {
			return Component<_Index>.Create();
        }
    }
}
