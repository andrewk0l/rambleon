namespace RambleOn.Domain.Common;

public interface IFullAudited : IAudited, IHasDeletionTime, IHasDeleter, ISoftDelete
{
    
}