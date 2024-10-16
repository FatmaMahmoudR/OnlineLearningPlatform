namespace OnlineLearningPlatform.App.interfaces
{
    public interface IUploudFile
    {
        Task<string> UploadFileAsync(string filePath, IFormFile file);
    
    }
}
