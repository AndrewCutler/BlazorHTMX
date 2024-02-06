namespace BlazorHTMX.Api.Handlers
{
    public interface IFormHandler
    {
        public bool IsValid();

        public IResult Submit();
    }
}
