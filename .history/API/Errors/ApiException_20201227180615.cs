namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        public ApiException(int statusCode, string message = null, string Details = null) : base(statusCode, message)
        {
        }

        public string Details { get; set; }
    }
}