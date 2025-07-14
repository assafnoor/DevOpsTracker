using Identity.Application.Common.Interface.Services;

namespace Identity.Infrastructure.Services;
public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}