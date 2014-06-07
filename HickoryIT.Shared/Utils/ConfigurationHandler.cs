using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Shared.Utils
{
    public class ConfigurationHandler
    {
        static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public static void SetValue(string key, string value)
        {
            try
            {
                //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection app = config.AppSettings;
                app.Settings.Add(key, value);
                config.Save(ConfigurationSaveMode.Modified);
            }
            catch (ConfigurationErrorsException e)
            {
                Console.WriteLine("[SetValue: {0}]",
                    e.ToString());
            }
        }

        public static string GetValue(string key)
        {
            string keyValue = null;
            try
            {
                keyValue = ConfigurationManager.AppSettings[key];
            }
            catch (ConfigurationErrorsException e)
            {
                Console.WriteLine("[ReadAppSettings: {0}]",
                    e.ToString());
            }
            return keyValue;
        }
    }
}
