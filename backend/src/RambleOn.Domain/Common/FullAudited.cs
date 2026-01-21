namespace RambleOn.Domain.Common;

public abstract class FullAudited : Audited, IFullAudited
{
    public DateTimeOffset? DeletionTime { get; set; }

    public string? DeleterId { get; set; }

    public bool IsDeleted { get; set; }

    public void SetDeletionTime(DateTimeOffset time) => DeletionTime = time;

    public void SetDeleter(string deleterId) => DeleterId = deleterId;

    public void Delete() => IsDeleted = true;
}