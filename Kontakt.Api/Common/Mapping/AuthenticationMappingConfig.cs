using Kontakt.Application.Authentication.Commands.Register;
using Kontakt.Application.Authentication.Common;
using Kontakt.Application.Authentication.Queries.Login;
using Kontakt.Contracts.Authentication;
using Mapster;

namespace Kontakt.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}