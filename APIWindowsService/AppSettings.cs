using System.Configuration;

namespace APIWindowsService
{
    public class AppSettings
    {
        public static string HostUrl
        {
            get { return GetAppSettingsString("hostUrl", string.Empty); }
        }

        public static string Miljo
        {
            get { return GetAppSettingsString("miljo", "du hakke satt miljo dummen!"); }
        }

        private static string GetAppSettingsString(string key, string fallback)
        {
            return ConfigurationManager.AppSettings[key] ?? fallback;
        }
    }
}