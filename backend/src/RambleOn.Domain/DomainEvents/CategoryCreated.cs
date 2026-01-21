namespace RambleOn.Domain.DomainEvents;
public record CategoryCreated : IDomainEvent
{
    public Guid CategoryId { get; init; }
    public string Name { get; init; } = string.Empty;
}