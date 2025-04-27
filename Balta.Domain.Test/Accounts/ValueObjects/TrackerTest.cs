using Balta.Domain.Accounts.ValueObjects.Exceptions;
using Balta.Domain.Shared.Abstractions;
using Balta.Domain.Test.Mocks;

namespace Balta.Domain.Test.Accounts.ValueObjects
{
    public class TrackerTest
    {
        private readonly IDateTimeProvider _dateTimeProvider = new FakeDateTimeProvider();

        [Fact]
        public void ShouldCreateTrackerWithCurrentUtcDateTime()
        {
            var tracker = Tracker.Create(_dateTimeProvider);
            Assert.Equal(_dateTimeProvider.UtcNow, tracker.CreatedAtUtc);
        }
    }
}
