using Kontakt.Domain.Entities;

namespace Kontakt.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetByEmail(string email);
    void Add(User user);
}