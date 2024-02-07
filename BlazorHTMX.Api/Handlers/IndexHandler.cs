using BlazorHTMX.Api.Models;

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
