using Balta.Domain.Shared.Abstractions;

namespace Balta.Domain.Test.Mocks
{
    public class FakeDateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow { get; } = new DateTime(2025, 2, 3, 7, 45, 32, DateTimeKind.Utc);
    }
}
