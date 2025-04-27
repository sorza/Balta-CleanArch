using Balta.Domain.Shared.Abstractions;
using Balta.Domain.Shared.ValueObjects;

namespace Balta.Domain.Accounts.ValueObjects.Exceptions
{
    public sealed record Tracker : ValueObject
    {
        #region Constructors
        public Tracker(DateTime createdAt, DateTime updatedAt)
        {
            CreatedAtUtc = createdAt;
            UpdatedAtUtc = updatedAt;
        }
        #endregion

        #region Factories
        public static Tracker Create(IDateTimeProvider dateTimeProvider) => new(dateTimeProvider.UtcNow, dateTimeProvider.UtcNow);

        public static Tracker Create(DateTime createdAtUtc, DateTime updatedAtUtc) => new(createdAtUtc, updatedAtUtc);

        #endregion

        #region Properties
        public DateTime CreatedAtUtc { get; }
        public DateTime? UpdatedAtUtc { get; private set; }

        #endregion

        #region Public Methods
        public void Update(IDateTimeProvider dateTimeProvider)
        {
            UpdatedAtUtc = dateTimeProvider.UtcNow;
        }

        #endregion
    }
}
