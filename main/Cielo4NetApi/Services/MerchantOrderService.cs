using System.Collections.Generic;
using Cielo4NetApi.Request;

namespace Cielo4NetApi.Services
{
    public class MerchantOrderService : Service
    {
        public ServiceResponse<List<MerchantOrder>> List(string merchantOrderId)
        {
            var request = new QueryMerchantOrderRequest(Merchant, Environment);

            return request.Execute(merchantOrderId);
        }
    }
}