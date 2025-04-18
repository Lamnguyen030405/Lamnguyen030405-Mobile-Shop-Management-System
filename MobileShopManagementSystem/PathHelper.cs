using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopManagementSystem
{
    internal static class PathHelper
    {
        public static string GetImagePath(string imagePath)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(basePath, imagePath);
        }
    }
}
