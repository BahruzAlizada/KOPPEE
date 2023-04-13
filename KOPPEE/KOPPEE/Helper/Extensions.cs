﻿using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace KOPPEE.Helper
{
    public static class Extensions
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }

        public static bool IsOlder216Kb(this IFormFile file)
        {
            return file.Length / 1024 > 1024 / 4;
        }

        public static async Task<string> SaveFileAsync(this IFormFile file, string folder)
        {
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string path = Path.Combine(folder, fileName);
            using(FileStream fileStream = new FileStream(path,FileMode.Create))
            {
               await file.CopyToAsync(fileStream);
            }
            return fileName;
        }
    }
}
