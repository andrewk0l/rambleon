namespace RambleOn.Domain.Common;

public interface IHasModifier
{
    string? ModifierId { get; set; }
    void SetModifier(string modifierId);
}