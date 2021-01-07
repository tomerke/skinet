namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        public ApiException(int statusCode, string message = null) : base(statusCode, message)
        {
        }
    }
}