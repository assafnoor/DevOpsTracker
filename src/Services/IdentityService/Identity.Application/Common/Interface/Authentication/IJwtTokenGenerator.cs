


using Identity.Domain.Users;

namespace Identity.Application.Common.Interface.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
