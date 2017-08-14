using System;
using System.Net;
using RestSharp;

namespace Cielo4NetApi
{
    public abstract class CieloEcommerceBase
    {
        protected CieloEcommerceBase(Merchant merchant)
        {
            Merchant = merchant;
        }

        public Merchant Merchant { get; }

        protected virtual RestClient CreateClient(string url, Merchant merchant)
        {
            var client = new RestClient(url)
            {
                Proxy = WebRequest.DefaultWebProxy
            };
            
            client.AddDefaultHeader("MerchantId", merchant.Id);
            client.AddDefaultHeader("MerchantKey", merchant.Key);

            return client;
        }

        protected virtual IRestRequest CreateRequest(Guid requestId, string resource, Method method)
        {
            var request = new RestRequest(resource, method)
            {
                JsonSerializer = new CieloJsonSerializer()
            };

            request.AddHeader("RequestId", requestId.ToString());

            return request;
        }
    }
}
