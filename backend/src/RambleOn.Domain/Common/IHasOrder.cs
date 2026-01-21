namespace RambleOn.Domain.Common;

public interface IHasOrder
{
    int DisplayOrder { get; set; }
    void SetOrder(int order);
}
