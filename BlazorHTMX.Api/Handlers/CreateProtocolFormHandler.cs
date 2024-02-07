using BlazorHTMX.Api.Models;
using BlazorHTMX.Api.Pages;

namespace BlazorHTMX.Api.Handlers
{
    public class CreateProtocolFormHandler : IFormHandler<CreateProtocolFormModel>
    {
        public bool IsValid()
        {
            return true;
        }

		public IResult Submit(CreateProtocolFormModel form)
		{
			if (!IsValid())
			{
				return Results.BadRequest($"Invalid {nameof(CreateProtocolFormModel)}.");
			}

			return Component<_Protocol, ProtocolParameters>.Create(new ProtocolParameters
			{
				ProtocolModel = new ProtocolModel
				{
					Name = form.Name,
				},
			});
		}
	}
}
