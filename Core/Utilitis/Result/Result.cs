namespace Core.Utilitis.Result
{
    public class Result : IResult
    {
        public Result( bool Success,string Message ):this(Success)
        {
            message=Message;
        }
        public Result(bool Success)
        {
            success=Success;
        }
        public bool success {get;}

        public string message {get;}
    }
}