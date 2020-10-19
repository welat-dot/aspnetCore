namespace Core.Utilitis.Result
{
    public class ErrorResult : Result
    {
        public ErrorResult(string Message) : base(Success: false, Message)
        {

        }
        public ErrorResult() : base(Success: false)
        {
        }


    }
}