using System.Configuration;

namespace TitleBarClock
{
    public class ConfigSection<TSection> where TSection : class
    {

        public TSection List { get; set;  }

        public ConfigSection(string section)
        {
            var configFileMap = new ExeConfigurationFileMap { ExeConfigFilename = Config.ApplicationFile };
            var configuration = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            List = configuration.GetSection(section) as TSection;
        }
    }
}
