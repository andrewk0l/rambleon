namespace RambleOn.Domain.Common;

public interface IHasCreator
{
    string CreatorId { get; set; }
    void SetCreator(string creatorId);
}