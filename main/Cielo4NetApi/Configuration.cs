using System;
using System.Configuration;

namespace Cielo4NetApi
{
    public static class Configuration
    {
        static Configuration()
        {
            var configurationSection = ConfigurationManager.GetSection("cielo") as ConfigurationSection;

            if(configurationSection == null)
                throw new Exception("Section \"cielo\" not defined.");

            MerchantId = configurationSection.MerchantId;
            MerchantKey = configurationSection.MerchantKey;
            Environment = configurationSection.Environment;
        }

        public static string MerchantId { get; }
        public static string MerchantKey { get; }
        public static string Environment { get; }
    }
}