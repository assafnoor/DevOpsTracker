
using System.Net;

namespace Identity.Application.Common.Errors;

public interface IServiceException
{   
    public HttpStatusCode StatusCode { get; }
    public string ErrorMessage { get;  }
}
