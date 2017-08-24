using Cielo4NetApi.Request;

namespace Cielo4NetApi.Services
{
    public class CardTokenService : Service
    {
        public ServiceResponse<CardToken> Create(CardToken cardToken)
        {
            var request = new CreateCardTokenRequest(Merchant, Environment);

            return request.Execute(cardToken);
        }
    }
}