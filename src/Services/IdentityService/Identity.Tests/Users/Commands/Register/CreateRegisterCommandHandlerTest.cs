using AutoFixture;
using FluentAssertions;
using Identity.Application.Authentication.Commands.Register;
using Identity.Application.Common.Interface.Authentication;
using Identity.Application.Common.Interface.Persistence;
using Identity.Domain.Users;
using Identity.Tests.TestUtils.Users.Extensions;
using Identity.Tests.Users.Commands.TestUtils;
using Moq;

namespace Identity.Tests;

public class RegisterCommandHandlerTest
{
    private readonly RegisterCommandHandler _handler;
    private readonly Mock<IUserRepository> _mockUserRepository;
    private readonly Mock<IJwtTokenGenerator> _mockJwtTokenGenerator;

    public RegisterCommandHandlerTest()
    {
        _mockUserRepository = new Mock<IUserRepository>();
        _mockJwtTokenGenerator = new Mock<IJwtTokenGenerator>();

        _mockJwtTokenGenerator
            .Setup(j => j.GenerateToken(It.IsAny<User>()))
            .Returns("fake-jwt-token");

        _handler = new RegisterCommandHandler(
            _mockJwtTokenGenerator.Object,
            _mockUserRepository.Object);
    }

    public static IEnumerable<object[]> ValidRegisterCommands()
    {
        yield return new[] { RegisterCommandUtils.CreateCommand() };
    }

    public static IEnumerable<object[]> GenerateValidRegisterCommands()
    {
        var fixture = new Fixture();
        int count = 5;
        for (int i = 0; i < count; i++)
        {
            var command = fixture.Build<RegisterCommand>()
                .With(c => c.Email, $"user@example.com")
                .Create();

            yield return new[] { command };
        }
    }

    [Theory]
    [MemberData(nameof(GenerateValidRegisterCommands))]
    public async Task Handle_ShouldCreateUser_WhenInputIsValid(RegisterCommand command)
    {
        // Arrange

        // Act
        var result = await _handler.Handle(command, default);

        // Assert
        result.IsError.Should().BeFalse();
        result.Value.ValidateCreatedFrom(command);

        _mockUserRepository.Verify(r => r.Add(It.IsAny<User>()), Times.Once);
    }
}