using System;
using RestSharp;

namespace Cielo4NetApi.Request
{
    public class DeactivateRecurrentSaleRequest : AbstractSaleRequest<Guid, RecurrentSale>
    {
        public DeactivateRecurrentSaleRequest(Merchant merchant, Environment environment) : base(merchant, environment)
        {
        }

        public override CieloResponse<RecurrentSale> Execute(Guid id)
        {
            var request = new RestRequest($"1/RecurrentPayment/{id:D}/Deactivate", Method.PUT)
            {
                JsonSerializer = new CieloJsonSerializer()
            };

            return Send(new RestClient(Environment.ApiQueryUrl), request);
        }
    }
}