﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Identity.Application.Common.Errors;

namespace Identity.Api.Controllers;
public class ErrorsController : ControllerBase
{
    [ApiExplorerSettings(GroupName = "Error")]
    [Route("/error")]
    public IActionResult Error()
    {
        
        Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        var (statusCode, message) = exception switch
        {
            IServiceException serviceException => ((int)serviceException.StatusCode, serviceException.ErrorMessage),
            _ => (StatusCodes.Status500InternalServerError, "An unexpected error occurred")
        };
        return Problem(statusCode:statusCode,title:message);
    }
}
