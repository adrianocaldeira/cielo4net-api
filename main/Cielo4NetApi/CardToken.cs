using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cielo4NetApi.Converters;
using Newtonsoft.Json;

namespace Cielo4NetApi
{
    public class CardToken
    {
        /// <summary>
        ///     Bandeira do cartão
        /// </summary>
        [JsonConverter(typeof(CreditCardBrandConverter))]
        public CreditCardBrand Brand { get; set; }

        /// <summary>
        ///     Número do Cartão do Comprador.
        /// </summary>
        public string CardNumber { get; set; }
        
        /// <summary>
        ///     Token de identificação do Cartão.
        /// </summary>
        [JsonProperty("CardToken")]
        public string Token { get; set; }

        public string CustomerName { get; set; }
        public string ExpirationDate { get; set; }
        public string Holder { get; set; }
    }
}
