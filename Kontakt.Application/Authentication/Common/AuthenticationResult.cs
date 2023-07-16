using Kontakt.Domain.Entities;

namespace Kontakt.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);