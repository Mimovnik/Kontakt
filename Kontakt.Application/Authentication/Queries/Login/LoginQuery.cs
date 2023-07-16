using ErrorOr;
using Kontakt.Application.Authentication.Common;
using MediatR;

namespace Kontakt.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;