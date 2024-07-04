using System;

namespace LogAn
{
    public class LogAnalyzer
    {
        private IExtensionManager _manager;

        public LogAnalyzer()
        {
            _manager = new FileExtensionManager();
        }

        public bool WasLastFileNameValid { get; set; }
        public IExtensionManager ExtensionManager
        {
            get { return _manager; }
            set { _manager = value; }
        }

        public bool IsValidLogFileName(string fileName)
        {
            WasLastFileNameValid = false;

            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("filename has to be provided");
            }

            try
            {
                WasLastFileNameValid = _manager.IsValid(fileName);
                return WasLastFileNameValid;
            }
            catch
            {
                return false;
            }
        }
    }
}
