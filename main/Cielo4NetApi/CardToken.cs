using Cielo4NetApi.Converters;
using Cielo4NetApi.Enumerators;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cielo4NetApi
{
    public class CardToken
    {
        /// <summary>
        ///     Bandeira do cartão
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
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

        /// <summary>
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// </summary>
        public string ExpirationDate { get; set; }

        /// <summary>
        /// </summary>
        public string Holder { get; set; }
    }
}