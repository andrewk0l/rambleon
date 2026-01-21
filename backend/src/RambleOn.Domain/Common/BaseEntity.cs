namespace RambleOn.Domain.Common;

public abstract class BaseEntity : Entity
{
    public Guid PublicId { get; protected set; } = Guid.NewGuid();
}