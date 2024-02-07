using BlazorHTMX.Api.Models;
using BlazorHTMX.Api.Pages;

namespace BlazorHTMX.Api.Handlers
{
    public class ProtocolTableHandler
    {
        public IResult Render()
        {
            var protocols = new List<ProtocolModel>();

            protocols.AddRange(
                new List<ProtocolModel>
                {
                    new ProtocolModel { Name = "Test 1", },
                    new ProtocolModel { Name = "Test 2", },
                    new ProtocolModel { Name = "Test 3", },
                }
            );

            return Component<_ProtocolTable, PaginatedProtocols>.Create(
                new PaginatedProtocols
                {
                    Protocols = protocols,
                    Skip = 0,
                    Take = 10,
                    Total = protocols.Count(),
                }
            );
        }
    }
}
