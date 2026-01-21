namespace RambleOn.Domain.Entities;

public class Post
{
    private readonly List<Category> _categories = new();
    private readonly List<Tag> _tags = new();

    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Content { get; private set; }
    public string? CoverImage { get; private set; }
    public bool IsPublished { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? PublishedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }
    
    public Guid AuthorId { get; private set; }
    public Author Author { get; private set; } = null!;
    
    public IReadOnlyCollection<Category> Categories => _categories.AsReadOnly();
    public IReadOnlyCollection<Tag> Tags => _tags.AsReadOnly();

    private Post() { }

    public static Post Create(
        string title,
        string content,
        string? coverImage,
        Guid authorId,
        List<Category> categories,
        List<Tag>? tags = null)
    {
        ValidateTitle(title);
        ValidateContent(content);
        ValidateCategories(categories);
        ValidateTags(tags);

        var post = new Post
        {
            Id = Guid.NewGuid(),
            Title = title,
            Content = content,
            CoverImage = coverImage,
            AuthorId = authorId,
            IsPublished = false,
            CreatedAt = DateTime.UtcNow
        };

        post._categories.AddRange(categories);
        if (tags != null)
            post._tags.AddRange(tags);

        return post;
    }

    public void Publish()
    {
        if (IsPublished)
            throw new InvalidOperationException("Post is already published");

        IsPublished = true;
        PublishedAt = DateTime.UtcNow;
    }

    public void Edit(string title, string content, string? coverImage)
    {
        ValidateTitle(title);
        ValidateContent(content);

        Title = title;
        Content = content;
        CoverImage = coverImage;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateCategories(List<Category> categories)
    {
        ValidateCategories(categories);
        
        _categories.Clear();
        _categories.AddRange(categories);
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateTags(List<Tag> tags)
    {
        ValidateTags(tags);
        
        _tags.Clear();
        _tags.AddRange(tags);
        UpdatedAt = DateTime.UtcNow;
    }

    private static void ValidateTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title is required");
    }

    private static void ValidateContent(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
            throw new ArgumentException("Content is required");

        var wordCount = content
            .Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Length;

        if (wordCount > 500)
            throw new ArgumentException("Content cannot exceed 500 words");
    }

    private static void ValidateCategories(List<Category> categories)
    {
        if (categories == null || categories.Count == 0)
            throw new ArgumentException("Post must have at least one category");
    }

    private static void ValidateTags(List<Tag>? tags)
    {
        if (tags != null && tags.Count > 10)
            throw new ArgumentException("Post cannot have more than 10 tags");
    }
}