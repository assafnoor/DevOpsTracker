using Identity.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace Identity.Application.Authentication.Queries.Login;

public record LoginQuery(
     string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;