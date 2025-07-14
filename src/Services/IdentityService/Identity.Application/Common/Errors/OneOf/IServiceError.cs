
using System.Net;
namespace Identity.Application.Common.Errors.OneOf;

public interface IServiceError
{
    public HttpStatusCode StatusCode { get; }
    public string ErrorMessage { get;  }
}
