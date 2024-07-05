namespace LogAn
{
    public class ExtensionManagerFactory
    {
        private static IExtensionManager _customManager;

        public static void SetManager(IExtensionManager mgr)
        {
            _customManager = mgr;
        }

        public static IExtensionManager Create()
        {
            if (_customManager != null)
            {
                return _customManager;
            }
            return new FileExtensionManager();
        }
    }
}