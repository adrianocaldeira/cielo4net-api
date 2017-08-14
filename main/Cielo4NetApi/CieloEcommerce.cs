namespace Cielo4NetApi
{
    /// <summary>
    /// 
    /// </summary>
    public class CieloEcommerce
    {
        public CieloEcommerce(Merchant merchant)
        {
            Merchant = merchant;
            Environment = Environment.Production();
        }

        public CieloEcommerce(Merchant merchant, Environment environment) : this(merchant)
        {
            Environment = environment;
        }

        public Merchant Merchant { get; }
        public Environment Environment { get; }

        public void CreateSale(Sale sale)
        {
            
        }
    }
}
