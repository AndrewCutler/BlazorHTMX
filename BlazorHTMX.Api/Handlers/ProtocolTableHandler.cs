using BlazorHTMX.Api.Models;
using BlazorHTMX.Api.Pages;

namespace BlazorHTMX.Api.Handlers
{
    public class ProtocolTableHandler
    {
        public IResult Render(PaginationRequest<ProtocolModel> pagination)
        {
			var result = pagination.Paginate(this.testProtocols);

            return Component<_ProtocolTable, PaginatedProtocols>.Create(
                new PaginatedProtocols
                {
                    Protocols = result,
                    Page = pagination.Page,
                    PageSize = pagination.PageSize,
                    Total = this.testProtocols.Count(),
                }
            );
		}

		private readonly List<ProtocolModel> testProtocols =
				new List<ProtocolModel>
				{
					new ProtocolModel { Name = "Test Name 1", Description = "Test Description 1" },
					new ProtocolModel { Name = "Test Name 2", Description = "Test Description 2" },
					new ProtocolModel { Name = "Test Name 3", Description = "Test Description 3" },
					new ProtocolModel { Name = "Test Name 4", Description = "Test Description 4" },
					new ProtocolModel { Name = "Test Name 5", Description = "Test Description 5" },
					new ProtocolModel { Name = "Test Name 6", Description = "Test Description 6" },
					new ProtocolModel { Name = "Test Name 7", Description = "Test Description 7" },
					new ProtocolModel { Name = "Test Name 8", Description = "Test Description 8" },
					new ProtocolModel { Name = "Test Name 9", Description = "Test Description 9" },
					new ProtocolModel { Name = "Test Name 10", Description = "Test Description 10" },
					new ProtocolModel { Name = "Test Name 11", Description = "Test Description 11" },
					new ProtocolModel { Name = "Test Name 12", Description = "Test Description 12" },
					new ProtocolModel { Name = "Test Name 13", Description = "Test Description 13" },
					new ProtocolModel { Name = "Test Name 14", Description = "Test Description 14" },
					new ProtocolModel { Name = "Test Name 15", Description = "Test Description 15" },
					new ProtocolModel { Name = "Test Name 16", Description = "Test Description 16" },
					new ProtocolModel { Name = "Test Name 17", Description = "Test Description 17" },
					new ProtocolModel { Name = "Test Name 18", Description = "Test Description 18" },
					new ProtocolModel { Name = "Test Name 19", Description = "Test Description 19" },
					new ProtocolModel { Name = "Test Name 20", Description = "Test Description 20" },
					new ProtocolModel { Name = "Test Name 21", Description = "Test Description 21" },
					new ProtocolModel { Name = "Test Name 22", Description = "Test Description 22" },
					new ProtocolModel { Name = "Test Name 23", Description = "Test Description 23" },
					new ProtocolModel { Name = "Test Name 24", Description = "Test Description 24" },
					new ProtocolModel { Name = "Test Name 25", Description = "Test Description 25" },
					new ProtocolModel { Name = "Test Name 26", Description = "Test Description 26" },
					new ProtocolModel { Name = "Test Name 27", Description = "Test Description 27" },
					new ProtocolModel { Name = "Test Name 28", Description = "Test Description 28" },
					new ProtocolModel { Name = "Test Name 29", Description = "Test Description 29" },
					new ProtocolModel { Name = "Test Name 30", Description = "Test Description 30" }
				};
	}
}
