using Balta.Domain.Shared.Events.Abstractions;

namespace Balta.Domain.Shared.Entities
{
    public abstract class Entity(Guid id) : IEquatable<Guid>
    {
        #region PrivateMembers
        private readonly List<IDomainEvent> _events = [];

        #endregion

        #region Properties
        public Guid Id { get; } = id;
        #endregion

        #region EquatableImplementation
        public bool Equals(Guid id) => Id == id;

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        #region DomainEvents
        public IReadOnlyCollection<IDomainEvent> Events => _events;
        public void ClearEvents() => _events.Clear();        
        public void RaiseEvent(IDomainEvent @event) => _events.Add(@event);

        #endregion
    }
}
