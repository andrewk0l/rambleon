namespace RambleOn.Domain.Common;

public abstract class AggregateRoot : Audited, IAggregateRoot
{
    private readonly List<IDomainEvent> _events = [];
    public IReadOnlyList<IDomainEvent> Events => _events.AsReadOnly();

    protected void RaiseDomainEvent(IDomainEvent domainEvent) =>_events.Add(domainEvent);
    public void ClearDomainEvents() => _events.Clear();

}