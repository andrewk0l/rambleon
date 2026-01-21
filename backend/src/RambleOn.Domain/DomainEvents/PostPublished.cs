namespace RambleOn.Domain.DomainEvents;

public record PostPublished : IDomainEvent
{
    public Guid PostId { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Slug { get; init; } = string.Empty;
}