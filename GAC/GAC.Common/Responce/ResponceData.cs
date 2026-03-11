using Microsoft.AspNetCore.Http;

namespace GAC.Common.Responce
{
    public class Response<T>
    {
        public bool IsSucceeded { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }


        public Response() { }


        public Response(T data, bool isSucceeded, string message = "", int statusCode = 200)
        {
            Data = data;
            IsSucceeded = isSucceeded;
            Message = message;
            StatusCode = statusCode;
        }


        public static Response<T> SetSuccessResponse(T data, string successMessage = "Success", int statusCode = StatusCodes.Status200OK)
        {
            return new Response<T> { IsSucceeded = true, Data = data, Message = successMessage, StatusCode = statusCode };
        }


        public static Response<T> SetSuccessMessageResponse(string successMessage, int statusCode = StatusCodes.Status200OK)
        {
            return new Response<T> { IsSucceeded = true, Message = successMessage, StatusCode = statusCode };
        }


        public static Response<T> SetErrorResponse(int statusCode)
        {
            return new Response<T> { IsSucceeded = false, Message = "DefaultErrorMessage", StatusCode = statusCode };
        }


        public static Response<T> SetCustomErrorResponse(string errorMessage, int statusCode)
        {
            return new Response<T> { IsSucceeded = false, Message = errorMessage, StatusCode = statusCode };
        }


        public static Response<T> NotFoundResponse(int statusCode = StatusCodes.Status404NotFound)
        {
            return new Response<T> { IsSucceeded = false, Message = "NotFound", StatusCode = statusCode };
        }


        public static Response<T> UserNotFoundResponse(int statusCode = StatusCodes.Status404NotFound)
        {
            return new Response<T> { IsSucceeded = false, Message = $"{"User"} {"NotFound"}", StatusCode = statusCode };
        }
    }
}
