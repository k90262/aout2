using System;

namespace LogAn
{
    public class FileExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            // TODO: read some file to check if support the extenstion.
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("filename has to be provided");
            }

            if (!fileName.EndsWith(".SLF",StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }

            return true;
        }
    }
}