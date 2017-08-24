using System;
using Cielo4NetApi.Request;

namespace Cielo4NetApi.Services
{
    public class RecurrentSaleService : Service
    {
        public ServiceResponse<RecurrentSale> Get(Guid id)
        {
            var request = new GetRecurrentSaleRequest(Merchant, Environment);

            return request.Execute(id);
        }

        public ServiceResponse<RecurrentSale> Deactivate(Guid id)
        {
            var deactivateRecurrentSaleRequest = new DeactivateRecurrentSaleRequest(Merchant, Environment);

            return deactivateRecurrentSaleRequest.Execute(id);
        }
    }
}