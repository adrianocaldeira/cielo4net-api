using System;

namespace Cielo4NetApi.Services
{
    public abstract class Service
    {
        protected Service()
        {
            Merchant = new Merchant(Configuration.MerchantId, Configuration.MerchantKey);

            if(Configuration.Environment.ToLower().Equals("production"))
                Environment =  Environment.Production();
            else if (Configuration.Environment.ToLower().Equals("sandbox"))
                Environment = Environment.Sandbox();
            else
                throw new Exception("Environment unrecognized.");
        }

        protected Service(Merchant merchant)
        {
            Merchant = merchant;
            Environment = Environment.Production();
        }

        protected Service(Merchant merchant, Environment environment) : this(merchant)
        {
            Environment = environment;
        }

        public Merchant Merchant { get; }
        public Environment Environment { get; }
    }
}