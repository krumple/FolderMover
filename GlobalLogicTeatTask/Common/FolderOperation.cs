using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.IO.Compression;
namespace GlobalLogicTeatTask.Common
{
    public static class FolderOperation
    {
        public static void MoveFolder(string startPath, string extractPath)
        {
            string tempPath = Path.GetTempPath() + Guid.NewGuid() + "MovingFolder";
            ZipFile.CreateFromDirectory(startPath, tempPath, CompressionLevel.Fastest, true);
            ZipFile.ExtractToDirectory(tempPath, extractPath);
        }
    }
}