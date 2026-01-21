namespace RambleOn.Domain.Common;

public interface IHasDeleter
{
    string? DeleterId { get; set; }
    public void SetDeleter(string deleterId) => DeleterId = deleterId;
}