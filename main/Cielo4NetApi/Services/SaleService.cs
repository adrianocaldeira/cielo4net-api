using System;
using Cielo4NetApi.Request;

namespace Cielo4NetApi.Services
{
    public class SaleService : Service
    {
        public SaleService(Merchant merchant) : base(merchant)
        {
        }

        public SaleService(Merchant merchant, Environment environment) : base(merchant, environment)
        {
        }

        public ServiceResponse<Sale> Create(Sale sale)
        {
            var request = new CreateSaleRequest(Merchant, Environment);

            return request.Execute(sale);
        }

        public ServiceResponse<Sale> Get(Guid id)
        {
            var request = new GetSaleRequest(Merchant, Environment);

            return request.Execute(id);
        }

        public ServiceResponse<SaleResponse> Cancel(Guid id, decimal? amount = null, decimal? serviceTaxAmount = null)
        {
            return UpdateSale("void", id, amount, serviceTaxAmount);
        }

        public ServiceResponse<SaleResponse> Capture(Guid id, decimal? amount = null, decimal? serviceTaxAmount = null)
        {
            return UpdateSale("capture", id, amount, serviceTaxAmount);
        }

        private ServiceResponse<SaleResponse> UpdateSale(string type, Guid id, decimal? amount = null, decimal? serviceTaxAmount = null)
        {
            var request = new UpdateSaleRequest(type, Merchant, Environment);

            if (amount.HasValue) request.WithAmount(amount.Value);
            if (serviceTaxAmount.HasValue) request.WithServiceTaxAmount(serviceTaxAmount.Value);

            return request.Execute(id);
        }
    }
}