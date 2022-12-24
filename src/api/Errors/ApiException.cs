using Microsoft.Extensions.Primitives;

namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode, string message = null, string details = null)
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;
        }

        /// <summary>
        /// HTTP exception StatusCode such as 500, Internal Server Error
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Exception message with a brief summary
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Exception details, generaly stack trace
        /// </summary>
        public string Details { get; set; }
    }
}
