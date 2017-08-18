using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cielo4NetApi
{
    /// <summary>
    ///     Venda
    /// </summary>
    public class Sale
    {
        /// <summary>
        ///     Numero de identificação do Pedido.
        /// </summary>
        [JsonProperty("MerchantOrderId")]
        public string Id { get; set; }

        /// <summary>
        ///     Comprador
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        ///     Pagamento
        /// </summary>
        public Payment Payment { get; set; }
    }

    public class SaleResponse
    {
        /// <summary>
        /// Numero de identificação do Pedido.
        /// </summary>
        [JsonProperty("MerchantOrderId")]
        public string SaleId { get; set; }
        public string Status { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonMessage { get; set; }
        public string ProviderReturnCode { get; set; }
        public string ProviderReturnMessage { get; set; }
        public string ReturnCode { get; set; }
        public string ReturnMessage { get; set; }
        public string AuthenticationUrl { get; set; }
        public List<Link> Links { get; set; }
        
    }
}