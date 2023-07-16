using Kontakt.Application.Common.Interfaces.Services;

namespace Kontakt.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}