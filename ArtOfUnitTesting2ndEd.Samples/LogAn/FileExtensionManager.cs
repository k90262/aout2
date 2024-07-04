using System;

namespace LogAn
{
    public class FileExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            // TODO: read some file to check if support the extenstion.
            return true;
        }
    }
}