namespace Core.Utilitis.Result
{
    public interface IDataResult<out T> : IResult
    {
        T data { get; }
    }
}