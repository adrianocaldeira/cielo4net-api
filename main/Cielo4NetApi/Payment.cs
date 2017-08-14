using Cielo4NetApi.Converters;
using Newtonsoft.Json;

namespace Cielo4NetApi
{
    /// <summary>
    ///     Pagamento
    /// </summary>
    public class Payment
    {
        /// <summary>
        ///     Inicializa uma nova instância da classe <see cref="Payment" />
        /// </summary>
        public Payment()
        {
            Currency = "BRL";
        }

        /// <summary>
        ///     Tipo do Meio de Pagamento.
        /// </summary>
        [JsonConverter(typeof(PaymentTypeConverter))]
        public PaymentType Type { get; set; }

        /// <summary>
        ///     Valor do Pedido (ser enviado em centavos).
        /// </summary>
        public long Amount { get; set; }

        /// <summary>
        ///     Moeda na qual o pagamento será feito (BRL).
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        ///     Define comportamento do meio de pagamento (https://developercielo.github.io/Webservice-3.0/#lista-de-providers)
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        ///     Total da transação que deve ser destinado ao pagamento da taxa de embarque à Infraero. O valor da taxa de embarque
        ///     não é acumulado ao valor da autorização.
        /// </summary>
        public long ServiceTaxAmount { get; set; }

        /// <summary>
        ///     Número de Parcelas.
        /// </summary>
        public short Installments { get; set; }

        /// <summary>
        ///     Tipo de parcelamento - Loja (ByMerchant) ou Cartão (ByIssuer).
        /// </summary>
        [JsonConverter(typeof(PaymentInterestConverter))]
        public PaymentInterestConverter Interest { get; set; }

        /// <summary>
        ///     Booleano que identifica que a autorização deve ser com captura automática.
        /// </summary>
        public bool Capture { get; set; }

        /// <summary>
        ///     Define se o comprador será direcionado ao banco emissor para autenticação do cartão
        /// </summary>
        public bool Authenticate { get; set; }
    }
}