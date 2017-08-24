using Cielo4NetApi.Services;
using RestSharp;

namespace Cielo4NetApi.Request
{
    public class CreateCardTokenRequest : AbstractSaleRequest<CardToken, CardToken>
    {
        public CreateCardTokenRequest(Merchant merchant, Environment environment) : base(merchant, environment)
        {
        }

        public override ServiceResponse<CardToken> Execute(CardToken cardToken)
        {
            var request = new RestRequest("1/card/", Method.POST)
            {
                JsonSerializer = new CieloJsonSerializer()
            };

            request.AddJsonBody(cardToken);

            return Send(new RestClient(Environment.ApiUrl), request);
        }
    }
}