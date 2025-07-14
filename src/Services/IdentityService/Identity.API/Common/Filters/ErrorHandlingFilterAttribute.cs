
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Identity.Api.Common.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        // var errorResult = new { error = "An error occurred while processing your request" };
        // context.Result = new ObjectResult(errorResult)
        // {
        //     StatusCode = 500
        // };

        var exception = context.Exception;
        var problemDetails = new ProblemDetails
        {
            Type="https://tools.ietf.org/html/rfc7231#section-6.6.1",
            Title = "An error occurred while processing your request",
            Instance = context.HttpContext.Request.Path,
            Status = (int)HttpStatusCode.InternalServerError,
            Detail = exception.Message,
        };
        context.Result = new ObjectResult(problemDetails);
        context.ExceptionHandled = true;
    }
}
