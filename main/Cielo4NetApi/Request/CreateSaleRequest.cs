using RestSharp;

namespace Cielo4NetApi.Request
{
    public class CreateSaleRequest : AbstractSaleRequest<Sale, Sale>
    {
        public CreateSaleRequest(Merchant merchant, Environment environment) : base(merchant, environment)
        {
        }

        public override CieloResponse<Sale> Execute(Sale sale)
        {
            var request = new RestRequest("1/sales/", Method.POST)
            {
                JsonSerializer = new CieloJsonSerializer()
            };

            request.AddJsonBody(sale);
            
            return Send(new RestClient(Environment.ApiUrl), request);
        }
    }
}
