using System;
using Cielo4NetApi.Services;
using RestSharp;

namespace Cielo4NetApi.Request
{
    public class GetRecurrentSaleRequest : AbstractSaleRequest<Guid, RecurrentSale>
    {
        public GetRecurrentSaleRequest(Merchant merchant, Environment environment) : base(merchant, environment)
        {
        }

        public override ServiceResponse<RecurrentSale> Execute(Guid id)
        {
            var request = new RestRequest("1/RecurrentPayment/" + id.ToString("D"), Method.GET)
            {
                JsonSerializer = new CieloJsonSerializer()
            };

            return Send(new RestClient(Environment.ApiQueryUrl), request);
        }
    }
}