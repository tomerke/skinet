namespace API.Errors
{
    public class ApiExc  eption : ApiResponse
    {
        public ApiException(int statusCode, string message = null) : base(statusCode, message)
        {
        }
    }
}