using Identity.Application.Authentication.Commands.Register;
using Identity.Tests.TestUtils.Constants;

namespace Identity.Tests.Users.Commands.TestUtils;

public static class RegisterCommandUtils
{
    public static RegisterCommand CreateCommand(
        string? firstName = null,
        string? lastName = null,
        string? email = null,
        string? password = null)
    {
        return new RegisterCommand(
            firstName ?? Constants.User.FirstName,
            lastName ?? Constants.User.LastName,
            email ?? Constants.User.Email,
            password ?? Constants.User.Password
        );
    }
}