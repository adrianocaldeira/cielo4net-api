using System.Collections.Generic;
using RestSharp;

namespace Cielo4NetApi.Request
{
    public class QueryMerchantOrderRequest : AbstractSaleRequest<string, List<MerchantOrder>>
    {
        public QueryMerchantOrderRequest(Merchant merchant, Environment environment) : base(merchant, environment)
        {
        }

        public override CieloResponse<List<MerchantOrder>> Execute(string id)
        {
            var request = new RestRequest($"1/sales?merchantOrderId={id}", Method.GET)
            {
                JsonSerializer = new CieloJsonSerializer()
            };

            return Send(new RestClient(Environment.ApiQueryUrl), request, "Payments");
        }
    }
}