namespace BlazorHTMX.Api.Handlers
{
    public interface IFormHandler<TForm>
    {
        bool IsValid();
		IResult Submit(TForm form);
    }
}
