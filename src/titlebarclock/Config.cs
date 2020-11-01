using System;
using Nini.Config;
using System.Reflection;
using System.IO;
using System.Configuration;

namespace TitleBarClock
{
    class Config
    {
        private static IConfigSource _source;
         
        public static string ApplicationFile { get; private set; }
        private static ConfigSection<ApplicationSection> _timezones;

        public static ConfigSection<ApplicationSection> Timezones
        {
            get 
            {
                return _timezones ?? (_timezones = new ConfigSection<ApplicationSection>("Timezones"));
            }
        }


        public static void SetConfigFile()
        {
            var location = AppDomain.CurrentDomain.BaseDirectory;
            var assembly = Assembly.GetExecutingAssembly().ManifestModule.Name;
            var defaultFile = Path.Combine(location, assembly + ".config");

            SetConfigFile(defaultFile);
        }

        private static void SetConfigFile(string defaultFile)
        {
            if (ApplicationFile != null)
                throw new InvalidOperationException("Cast file can be set only once, it is already set to " + ApplicationFile);

            if (!File.Exists(defaultFile))
                throw new FileNotFoundException("Config file specified does no exist", defaultFile);

            ApplicationFile = defaultFile;
            _source = new DotNetConfigSource(ApplicationFile);
        }
    }
}
