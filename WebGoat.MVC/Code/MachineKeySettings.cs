using System.Web;
using System.Web.Configuration;

namespace WebGoat.MVC.Code
{
    public class MachineKeySettings
    {
        public static string MachineKey
        {
            get
            {
                string configPath = string.Empty;
                System.Configuration.Configuration config;

                configPath = HttpContext.Current.Request.ApplicationPath;
                config = WebConfigurationManager.OpenWebConfiguration(configPath);

                MachineKeySection configSection = (MachineKeySection)config.GetSection("system.web/machineKey");
                return configSection.DecryptionKey;
            }
        }
    }
}