using System.Configuration;
using System.Security.Policy;

namespace TitleBarClock
{
    public class ApplicationSection : ConfigurationSection
    {
        [ConfigurationProperty("Data")]
        public ApplicationCollection Data
        {
            get { return (ApplicationCollection)base["Data"]; }
        }

    }

    [ConfigurationCollection(typeof(ApplicationConfiguration), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
    public class ApplicationCollection : ConfigurationElementCollection
    { 
        public new ApplicationConfiguration this[string name] 
        {
            get { return (ApplicationConfiguration)BaseGet(name); }
        }

        public ApplicationConfiguration this[int index]
        { 
            get { return (ApplicationConfiguration)BaseGet(index); }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ApplicationConfiguration();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            var configuration = element as ApplicationConfiguration;
            return configuration != null ? configuration.Name : "null";
        }
    }

    public class ApplicationConfiguration : ConfigurationElement 
    {
        [ConfigurationProperty("id", IsRequired = true)]
        public int Id
        {
            get { return (int)base["id"]; }
        }

        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return (string)base["name"]; }
        }

        [ConfigurationProperty("zone", IsRequired = true)]
        public string Zone
        {
            get { return (string)base["zone"]; }
        }

        [ConfigurationProperty("format", IsRequired = true)]
        public string Format
        {
            get { return (string)base["format"]; }
        }

        [ConfigurationProperty("flag", IsRequired = false)]
        public string Flag
        {
            get { return (string)base["flag"]; }
        }
    }
 }
