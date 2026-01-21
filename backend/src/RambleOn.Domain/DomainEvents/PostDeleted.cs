namespace RambleOn.Domain.DomainEvents;

public record PostDeleted : IDomainEvent
{
    public Guid PostId { get; init; }
    public string DeletedBy { get; init; } = string.Empty;
}