using Cielo4NetApi.Request;
using RestSharp;

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

        public CieloEcommerceResponse<Sale> CreateSale(Sale sale)
        {
            var createSaleRequest = new CreateSaleRequest(Merchant, Environment);

            return createSaleRequest.Execute(sale);
        }
    }
}
