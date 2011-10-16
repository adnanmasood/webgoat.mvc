using System.Web.Configuration;

namespace WebGoat.MVC.Code
{
    public class AppSettingsConfig
    {
        public const string INITPASS = "InitPass";

        public static string InitPass
        {
            get { return WebConfigurationManager.AppSettings[INITPASS]; }
        }
    }
}