using OnlineLearningPlatform.App.interfaces;

namespace OnlineLearningPlatform.App.Repositories
{
    public class UploadFile : IUploudFile
    {
        private IWebHostEnvironment _environment;

        public UploadFile(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        /// <summary>
        /// upload a file to a specified directory on the server. 
        /// If the directory does not exist, it creates it. The uploaded file is given a 
        /// unique name to prevent overwriting existing files.
        /// </summary>
        /// <param name="filePath">The relative path to the upload directory.</param>
        /// <param name="file">The file to be uploaded.</param>
        /// <returns>Returns the relative path of the uploaded file including its unique name.</returns>

        public async Task<string> UploadFileAsync(string filePath, IFormFile file)
        {
            string upLoadFolder = _environment.WebRootPath + filePath;
            if (Directory.Exists(upLoadFolder) == false)
            {
                Directory.CreateDirectory(upLoadFolder);
            }
            string UniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            string FullPath = Path.Combine(upLoadFolder, UniqueFileName);

            using (var stream = new FileStream(FullPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
                stream.Dispose();
            }
            return filePath + UniqueFileName;
        }
    }
}
