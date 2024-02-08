using System.Text.Json.Serialization;

namespace BlazorHTMX.Api.Models
{
	public record PaginationRequest<T>
	{
		public int Page { get; set; } = 1;
		public int PageSize { get; set; } = 10;
		[JsonIgnore]
		public int Skip => (this.Page - 1) * this.PageSize;

		public IEnumerable<T> Paginate(IEnumerable<T> data)
		{
			return data.Skip(this.Skip).Take(this.PageSize);
		}
	}
}
