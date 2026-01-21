namespace RambleOn.Domain.Common;

public interface IHasPublishing
{
    bool IsPublished { get; set; }
    DateTimeOffset? PublishedTime { get; set; }
    DateTimeOffset? UnpublishedTime { get; set; }
    
    void Publish();
    void Unpublish();
}