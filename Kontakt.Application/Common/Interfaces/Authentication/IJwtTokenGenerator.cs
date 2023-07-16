using Kontakt.Domain.Entities;

namespace Kontakt.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}