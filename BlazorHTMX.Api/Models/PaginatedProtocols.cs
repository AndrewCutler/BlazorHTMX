namespace BlazorHTMX.Api.Models
{
	public record PaginatedProtocols
	{
		public IEnumerable<ProtocolModel> Protocols { get; set; } = Enumerable.Empty<ProtocolModel>();
		public int Skip { get; set; } = 0;
		public int Take { get; set; } = 10;
		public int Total { get; set; } = 0;
	}
}
