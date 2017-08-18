using System;
using RestSharp;

namespace Cielo4NetApi.Request
{
    public class QuerySaleRequest : AbstractSaleRequest<Guid, Sale>
    {
        public QuerySaleRequest(Merchant merchant, Environment environment) : base(merchant, environment)
        {
        }

        public override CieloResponse<Sale> Execute(Guid id)
        {
            var request = new RestRequest("1/sales/" + id.ToString("D"), Method.GET)
            {
                JsonSerializer = new CieloJsonSerializer()
            };

            return Send(new RestClient(Environment.ApiQueryUrl), request);
        }
    }
}