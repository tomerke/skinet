namespace API.Errors
{
    public class ApiResponse
    {


        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}