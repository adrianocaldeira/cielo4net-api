namespace Cielo4NetApi.Services
{
    public abstract class Service
    {
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