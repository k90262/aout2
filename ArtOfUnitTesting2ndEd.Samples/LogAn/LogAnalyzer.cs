using System;

namespace LogAn
{
    public class LogAnalyzer
    {
        public LogAnalyzer()
        {
        }

        public bool WasLastFileNameValid { get; set; }

        public bool IsValidLogFileName(string fileName)
        {
            WasLastFileNameValid = false;

            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("filename has to be provided");
            }

            try
            {
                WasLastFileNameValid = GetManager().IsValid(fileName);
                return WasLastFileNameValid;
            }
            catch
            {
                return false;
            }
        }

        protected virtual IExtensionManager GetManager()
        {
            return new FileExtensionManager();
        }
    }
}
