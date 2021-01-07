namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse()
        {
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}