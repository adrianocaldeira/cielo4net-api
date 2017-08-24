using Cielo4NetApi.Request;

namespace Cielo4NetApi.Services
{
    public class CardTokenService : Service
    {
        public CardTokenService(Merchant merchant) : base(merchant)
        {
        }

        public CardTokenService(Merchant merchant, Environment environment) : base(merchant, environment)
        {
        }

        public ServiceResponse<CardToken> Create(CardToken cardToken)
        {
            var request = new CreateCardTokenRequest(Merchant, Environment);

            return request.Execute(cardToken);
        }
    }
}