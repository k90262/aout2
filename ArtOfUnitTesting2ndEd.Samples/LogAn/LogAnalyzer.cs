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
            try
            {
                WasLastFileNameValid = false;

                if (!_manager.IsValid(fileName)) return false;

                WasLastFileNameValid = true;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
