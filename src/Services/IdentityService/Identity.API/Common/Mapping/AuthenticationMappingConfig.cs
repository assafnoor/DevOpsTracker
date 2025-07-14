using Identity.Application.Authentication.Commands.Register;
using Identity.Application.Authentication.Common;
using Identity.Application.Authentication.Queries.Login;
using Identity.Contracts.Authentication;
using Identity.Domain.Users.ValueObjects;
using Mapster;

namespace Identity.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();
        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest.Token, src => src.Token)
            .Map(dest => dest, src => src.User)
            .Map(dest => dest.Id, src => UserId.Create(src.User.Id.Value));
    }
}