namespace RambleOn.Domain.Common;

public abstract class Audited : BaseEntity, IAudited
{
    public DateTimeOffset CreationTime { get; set; }

    public string CreatorId { get; set; } = string.Empty;

    public DateTimeOffset? ModificationTime { get; set; }

    public string? ModifierId { get; set; }

    public void SetCreationTime(DateTimeOffset time) => CreationTime = time;

    public void SetCreator(string creatorId) => CreatorId = creatorId;

    public void SetModificationTime(DateTimeOffset time) => ModificationTime = time;

    public void SetModifier(string modifierId) => ModifierId = modifierId;
}