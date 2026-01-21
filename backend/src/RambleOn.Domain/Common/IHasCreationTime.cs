namespace RambleOn.Domain.Common;

public interface IHasCreationTime
{
    DateTimeOffset CreationTime { get; set; }

    void SetCreationTime(DateTimeOffset time);
}