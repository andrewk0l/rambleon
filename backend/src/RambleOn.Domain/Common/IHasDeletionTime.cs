namespace RambleOn.Domain.Common;

public interface IHasDeletionTime
{
    DateTimeOffset? DeletionTime { get; set; }
    void SetDeletionTime(DateTimeOffset time) => DeletionTime = time;
}