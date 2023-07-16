namespace Kontakt.Contracts.Authentication;

public record LoginRequest(
    string Email,
    string Password
);