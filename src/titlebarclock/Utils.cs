using System;
using System.Collections;
using System.Configuration;

namespace TitleBarClock
{
    public static class Utils
    {

        public static ArrayList SplitString(string data, char delimiter)
        {
            ArrayList list = new ArrayList();

            foreach (var item in data.Split(delimiter))
                list.Add(item);

            return list;
        }

        public static string GetConfigString(string key)
        {
            var value = ConfigurationManager.AppSettings[key];

            return value;
        }

        public static bool GetConfigBool(string key)
        {
            var value = Boolean.Parse(ConfigurationManager.AppSettings[key]);

            return value;
        }

        public static int GetConfigInt(string key)
        {
            var value = Int32.Parse(ConfigurationManager.AppSettings[key]);

            return value;
        }
    }
}
