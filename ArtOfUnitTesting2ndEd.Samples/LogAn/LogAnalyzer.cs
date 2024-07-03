namespace LogAn
{
    public class LogAnalyzer
    {
        private IExtensionManager _manager;

        public LogAnalyzer(IExtensionManager mgr)
        {
            _manager = mgr;
        }

        public bool WasLastFileNameValid { get; set; }

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
