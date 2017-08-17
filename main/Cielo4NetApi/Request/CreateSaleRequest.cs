using Newtonsoft.Json;
using RestSharp;

namespace Cielo4NetApi.Request
{
    public class CreateSaleRequest : AbstractSaleRequest<Sale, Sale>
    {
        public CreateSaleRequest(Merchant merchant, Environment environment) : base(merchant, environment)
        {
        }

        public override CieloEcommerceResponse<Sale> Execute(Sale sale)
        {
            var request = new RestRequest("1/sales/", Method.POST);

            var json = JsonConvert.SerializeObject(sale, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            //request.AddParameter("application/json", json, ParameterType.RequestBody);

            request.JsonSerializer = new CieloJsonSerializer();
            request.AddJsonBody(sale);
            
            var response = Send(new RestClient(Environment.ApiUrl), request);

            return response;
        }
    }
}
