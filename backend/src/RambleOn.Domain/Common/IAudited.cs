namespace RambleOn.Domain.Common;

public interface IAudited : IHasCreationTime, IHasCreator, IHasModificationTime, IHasModifier
{
    
}