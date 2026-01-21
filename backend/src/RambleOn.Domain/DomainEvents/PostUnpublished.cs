namespace RambleOn.Domain.DomainEvents;

public record PostUnpublished : IDomainEvent
{
    public Guid PostId { get; init; }
}