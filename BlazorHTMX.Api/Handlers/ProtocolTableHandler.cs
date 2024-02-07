using BlazorHTMX.Api.Models;

namespace BlazorHTMX.Api.Handlers
{
	public class ProtocolTableHandler
	{
		public IResult Render()
		{
			var protocols = new List<ProtocolModel>();

			return Component<_Index, IEnumerable<ProtocolModel>>.Create(protocols);
		}
	}
}
