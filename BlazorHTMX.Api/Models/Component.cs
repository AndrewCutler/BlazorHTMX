using Microsoft.AspNetCore.Http.HttpResults;

namespace BlazorHTMX.Api.Models
{
	public class Component<TRazor, TParameters>
	{
		public static RazorComponentResult Create(TParameters? parameters)
		{
			if (parameters is null) return new RazorComponentResult(typeof(TRazor);

			return new RazorComponentResult(typeof(TRazor), parameters);
		}
	}
}
