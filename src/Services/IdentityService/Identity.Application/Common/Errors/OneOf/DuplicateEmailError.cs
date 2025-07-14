
using System.Net;

namespace Identity.Application.Common.Errors.OneOf;

public class DuplicateEmailError:IServiceError
{
    public HttpStatusCode StatusCode => HttpStatusCode.Conflict;
    public string ErrorMessage => "Email already exists";
}
