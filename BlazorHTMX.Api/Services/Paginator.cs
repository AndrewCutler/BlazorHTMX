namespace BlazorHTMX.Api.Services
{
	public class Paginator<T>
	{
		private int _skip = 0;
		private int _take = 10;
		private IEnumerable<T> _data = Enumerable.Empty<T>();

		public Paginator(IEnumerable<T> data)
		{
			this._data = data;
		}

		public Paginator(IEnumerable<T> data, int take)
		{
			this._data = data;
			this._take = take;
		}

		public IEnumerable<T> Paginate(int? take = null, int? skip = null)
		{
			if (take is not null) this._take = (int)take!;
			if (skip is not null) this._skip = (int)skip!;

			return this._data
				.Skip(this._skip)
				.Take(this._take);
		}

		public int Total => this._data.Count();
		public int Page => (int)((Math.Ceiling(((double)this._skip / this._take)) + 1));
	}
}
