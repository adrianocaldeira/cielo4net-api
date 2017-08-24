using System;
using Cielo4NetApi.Helpers;
using Cielo4NetApi.Services;
using RestSharp;

namespace Cielo4NetApi.Request
{
    public class UpdateSaleRequest : AbstractSaleRequest<Guid, SaleResponse>
    {
        public UpdateSaleRequest(string type, Merchant merchant, Environment environment) : base(merchant, environment)
        {
            Type = type;
        }

        public string Type { get; }
        public decimal? Amount { get; private set; }
        public decimal? ServiceTaxAmount { get; private set; }

        public UpdateSaleRequest WithAmount(decimal amount)
        {
            Amount = amount;
            return this;
        }

        public UpdateSaleRequest WithServiceTaxAmount(decimal serviceTaxAmount)
        {
            ServiceTaxAmount = serviceTaxAmount;
            return this;
        }

        public override ServiceResponse<SaleResponse> Execute(Guid id)
        {
            ServiceResponse<SaleResponse> saleResponse = null;

            try
            {
                var request = new RestRequest($"1/sales/{id:D}/{Type}", Method.PUT)
                {
                    JsonSerializer = new CieloJsonSerializer()
                };

                if (Amount.HasValue)
                {
                    request.AddParameter("amount", NumberHelper.DecimalToInteger(Amount.Value));
                }

                if (ServiceTaxAmount.HasValue)
                {
                    request.AddParameter("serviceTaxAmount", NumberHelper.DecimalToInteger(ServiceTaxAmount.Value));
                }

                saleResponse = Send(new RestClient(Environment.ApiUrl), request);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return saleResponse;
        }
    }
}