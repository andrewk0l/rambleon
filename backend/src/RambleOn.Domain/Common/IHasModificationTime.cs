namespace RambleOn.Domain.Common;

public interface IHasModificationTime
{
    DateTimeOffset? ModificationTime { get; set; }
    void SetModificationTime(DateTimeOffset time);
}