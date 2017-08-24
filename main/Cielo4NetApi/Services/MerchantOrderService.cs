using System.Collections.Generic;
using Cielo4NetApi.Request;

namespace Cielo4NetApi.Services
{
    public class MerchantOrderService : Service
    {
        public MerchantOrderService(Merchant merchant) : base(merchant)
        {
        }

        public MerchantOrderService(Merchant merchant, Environment environment) : base(merchant, environment)
        {
        }

        public ServiceResponse<List<MerchantOrder>> List(string merchantOrderId)
        {
            var request = new QueryMerchantOrderRequest(Merchant, Environment);

            return request.Execute(merchantOrderId);
        }
    }
}