using System;
using Cielo4NetApi.Services;
using RestSharp;

namespace Cielo4NetApi.Request
{
    public class GetSaleRequest : AbstractSaleRequest<Guid, Sale>
    {
        public GetSaleRequest(Merchant merchant, Environment environment) : base(merchant, environment)
        {
        }

        public override ServiceResponse<Sale> Execute(Guid id)
        {
            var request = new RestRequest("1/sales/" + id.ToString("D"), Method.GET)
            {
                JsonSerializer = new CieloJsonSerializer()
            };

            return Send(new RestClient(Environment.ApiQueryUrl), request);
        }
    }
}