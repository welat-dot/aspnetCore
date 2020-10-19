namespace Core.Utilitis.Result
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T Data, bool Success, string Message) : base(Success, Message)
        {
            data = Data;
        }
        public DataResult(T Data, bool Success) : base(Success)
        {
            data = Data;
        }


        public T data { get; }
    }
}