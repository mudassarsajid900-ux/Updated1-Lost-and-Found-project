using GAC.Common.Constants;
using GAC.Common.Responce;
using Microsoft.AspNetCore.Mvc;

namespace GAC.Application.Extensions;

public static class ApiResponseExtensions
{
    /// <summary>
    /// Converts the specified response object to an HTTP result suitable for ASP.NET Core action methods.
    /// </summary>
    /// <remarks>The returned result sets the status code and content type based on the success or failure of
    /// the response. Use this extension method to standardize HTTP responses from service or controller
    /// logic.</remarks>
    /// <typeparam name="T">The type of the value contained in the response.</typeparam>
    /// <param name="response">The response to convert to an HTTP result. Must not be null.</param>
    /// <returns>An <see cref="IActionResult"/> representing the HTTP response, with status code and content type set according
    /// to the response's properties.</returns>
    public static IActionResult ToHttpResult<T>(this Response<T> response)
    {
        var returnRes = new ObjectResult(response)
        {
            StatusCode = response.StatusCode,
            ContentTypes = response.IsSucceeded ? [HttpConstants.ContentTypeJsonValue] : [HttpConstants.ContentTypeProblemJsonValue],
            Value = response
        };

        return returnRes;
    }
}

