using System.Configuration;

namespace Cielo4NetApi
{
    public class ConfigurationSection : System.Configuration.ConfigurationSection
    {
        [ConfigurationProperty("merchantId", IsRequired = true)]
        public string MerchantId
        {
            get => (string) base["merchantId"];
            set => base["merchantId"] = value;
        }

        [ConfigurationProperty("merchantKey", IsRequired = true)]
        public string MerchantKey
        {
            get => (string) base["merchantKey"];
            set => base["merchantKey"] = value;
        }

        [ConfigurationProperty("environment", IsRequired = true)]
        public string Environment
        {
            get => (string) base["environment"];
            set => base["environment"] = value;
        }
    }
}