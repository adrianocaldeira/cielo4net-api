using System;
using System.Collections.Generic;
using Cielo4NetApi.Request;
using RestSharp;

namespace Cielo4NetApi
{
    /// <summary>
    /// 
    /// </summary>
    public class CieloEcommerce
    {
        public CieloEcommerce(Merchant merchant)
        {
            Merchant = merchant;
            Environment = Environment.Production();
        }

        public CieloEcommerce(Merchant merchant, Environment environment) : this(merchant)
        {
            Environment = environment;
        }

        public Merchant Merchant { get; }
        public Environment Environment { get; }

        public CieloResponse<Sale> CreateSale(Sale sale)
        {
            var createSaleRequest = new CreateSaleRequest(Merchant, Environment);

            return createSaleRequest.Execute(sale);
        }

        public CieloResponse<CardToken> CreateCardToken(CardToken cardToken)
        {
            var createCardTokenRequest = new CreateCardTokenRequest(Merchant, Environment);

            return createCardTokenRequest.Execute(cardToken);
        }

        public CieloResponse<Sale> QuerySale(Guid paymentId)
        {
            var querySaleRequest = new QuerySaleRequest(Merchant, Environment);

            return querySaleRequest.Execute(paymentId);
        }

        public CieloResponse<List<MerchantOrder>> QueryMerchantOrder(string merchantOrderId)
        {
            var querySaleRequest = new QueryMerchantOrderRequest(Merchant, Environment);

            return querySaleRequest.Execute(merchantOrderId);
        }


        public CieloResponse<SaleResponse> CancelSale(Guid paymentId, decimal? amount = null, decimal? serviceTaxAmount = null)
        {
            return UpdateSale("void", paymentId, amount, serviceTaxAmount);
        }

        public CieloResponse<SaleResponse> CaptureSale(Guid paymentId, decimal? amount = null, decimal? serviceTaxAmount = null)
        {
            return UpdateSale("capture", paymentId, amount, serviceTaxAmount);
        }

        private CieloResponse<SaleResponse> UpdateSale(string type, Guid paymentId, decimal? amount = null, decimal? serviceTaxAmount = null)
        {
            var updateSaleRequest = new UpdateSaleRequest(type, Merchant, Environment);

            if (amount.HasValue) updateSaleRequest.WithAmount(amount.Value);
            if (serviceTaxAmount.HasValue) updateSaleRequest.WithAmount(serviceTaxAmount.Value);

            return updateSaleRequest.Execute(paymentId);
        }
    }
}
