namespace RambleOn.Domain.Contracts;

public interface ISlugGeneratorService
{
    string GenerateSlug(string text);
    Task<string> EnsureUniqueSlugAsync(string baseSlug, Func<string, Task<bool>> existsCheck);   
}