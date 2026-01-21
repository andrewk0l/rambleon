namespace RambleOn.Domain.Contracts;

public interface IFileStorageService
{
    Task<string> UploadAsync(Stream fileStream, string fileName, string contentType);
    Task<Stream> DownloadAsync(string fileUrl);
    Task DeleteAsync(string fileUrl);
    Task<string> GetPublicUrlAsync(string fileUrl);   
}