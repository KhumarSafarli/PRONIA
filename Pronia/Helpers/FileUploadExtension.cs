﻿using Pronia.Entities;

namespace Pronia.Helpers
{
    public static class FileUploadExtension
    {
        public static async Task<string> GeneratePhoto(this IFormFile file, params string[] folders)
        {
            string folderPath = Path.Combine(folders);
            string fileName = Guid.NewGuid() + file.FileName;
            string fullPath = Path.Combine(folderPath, fileName);

            using (FileStream stream = new FileStream(fullPath, FileMode.CreateNew))
            {
                await file.CopyToAsync(stream);
            }
            return fileName;
        }
    }
}
