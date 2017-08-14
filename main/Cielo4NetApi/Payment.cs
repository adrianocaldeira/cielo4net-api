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
        ///     Inicializa uma nova inst�ncia da classe <see cref="Payment" />
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
        ///     Moeda na qual o pagamento ser� feito (BRL).
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        ///     Define comportamento do meio de pagamento (https://developercielo.github.io/Webservice-3.0/#lista-de-providers)
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        ///     Total da transa��o que deve ser destinado ao pagamento da taxa de embarque � Infraero. O valor da taxa de embarque
        ///     n�o � acumulado ao valor da autoriza��o.
        /// </summary>
        public long ServiceTaxAmount { get; set; }

        /// <summary>
        ///     N�mero de Parcelas.
        /// </summary>
        public short Installments { get; set; }

        /// <summary>
        ///     Tipo de parcelamento - Loja (ByMerchant) ou Cart�o (ByIssuer).
        /// </summary>
        [JsonConverter(typeof(PaymentInterestConverter))]
        public PaymentInterestConverter Interest { get; set; }

        /// <summary>
        ///     Booleano que identifica que a autoriza��o deve ser com captura autom�tica.
        /// </summary>
        public bool Capture { get; set; }

        /// <summary>
        ///     Define se o comprador ser� direcionado ao banco emissor para autentica��o do cart�o
        /// </summary>
        public bool Authenticate { get; set; }
    }
}