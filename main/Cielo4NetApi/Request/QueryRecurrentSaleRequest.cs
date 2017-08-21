using System;
using RestSharp;

namespace Cielo4NetApi.Request
{
    public class QueryRecurrentSaleRequest : AbstractSaleRequest<Guid, RecurrentSale>
    {
        public QueryRecurrentSaleRequest(Merchant merchant, Environment environment) : base(merchant, environment)
        {
        }

        public override CieloResponse<RecurrentSale> Execute(Guid id)
        {
            var request = new RestRequest("1/RecurrentPayment/" + id.ToString("D"), Method.GET)
            {
                JsonSerializer = new CieloJsonSerializer()
            };

            return Send(new RestClient(Environment.ApiQueryUrl), request);
        }
    }
}