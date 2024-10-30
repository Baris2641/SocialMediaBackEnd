namespace Core.Utilities.Result.Concrete
{
    public class ErrorResult : Result {
        public ErrorResult() : base(true)
        {

        }

        public ErrorResult(string message) : base(true, message)
        {

        }
    }
}
