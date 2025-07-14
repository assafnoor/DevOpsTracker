using FluentAssertions;
using Identity.Application.Authentication.Commands.Register;
using Identity.Application.Authentication.Common;

namespace Identity.Tests.TestUtils.Users.Extensions;

public static class AuthenticationResultExtensions
{
    public static void ValidateCreatedFrom(this AuthenticationResult authResult, RegisterCommand command)
    {
        var user = authResult.User;

        user.Id.Should().NotBeNull();
        user.FirstName.Should().Be(command.FirstName);
        user.LastName.Should().Be(command.LastName);
        user.Email.Should().Be(command.Email);
        //user.Password.Should().Be(command.Password); // أو تأكد من Hash لو فيه

        user.CreatedDateTime.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));
        user.UpdatedDateTime.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));

        authResult.Token.Should().NotBeNullOrEmpty();
    }
}