using Identity.Domain.Users;

namespace Identity.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);