using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Uwp_ReadFiles.Helpers
{
        public static class FileHelper
        {
            public static async Task<string> GetFileContentAsync(string fileName)
            {
                StorageFolder storageFolder = KnownFolders.DocumentsLibrary;
                StorageFile file = await storageFolder.GetFileAsync(fileName);

                return await FileIO.ReadTextAsync(file);

            }

        }


    }

