using System;

namespace API.Errors
{
    public class ApiResponse
    {


        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(StatusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            throw new NotImplementedException();
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}