namespace RambleOn.Domain.Entities;

public class Author
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string PenName { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string Bio { get; private set; }
    public string? ProfilePicture { get; private set; }
    public DateTime CreatedAt { get; private set; }
    
    private Author() { }
    
    public static Author Create(
        string name,
        string penName,
        string email,
        string password,
        string bio)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required");
        
        if (string.IsNullOrWhiteSpace(penName))
            throw new ArgumentException("Pen name is required");
        
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email is required");
        
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password is required");

        return new Author
        {
            Id = Guid.NewGuid(),
            Name = name,
            PenName = penName,
            Email = email,
            Password = password,
            Bio = bio ?? string.Empty,
            CreatedAt = DateTime.UtcNow
        };
    }
    
    public void UpdateProfile(string name, string bio, string? profilePicture)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required");

        Name = name;
        Bio = bio ?? string.Empty;
        ProfilePicture = profilePicture;
    }
}