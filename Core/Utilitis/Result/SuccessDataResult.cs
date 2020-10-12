namespace Core.Utilitis.Result
{
    public class SuccessDataResult<T> : DataResult<T>
    {

        public SuccessDataResult(T Data, string Message) : base(Data, true, Message)
        {
        }
        public SuccessDataResult(T Data) : base(Data, true)
        {
        }

    }
}