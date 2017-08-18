using System;
using System.Collections.Generic;
using Cielo4NetApi.Converters;
using Cielo4NetApi.Enumerators;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
            Currency = Enumerators.Currency.Brl;
        }

        /// <summary>
        ///     Tipo do Meio de Pagamento.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentType Type { get; set; }

        /// <summary>
        ///     Valor do Pedido (ser enviado em centavos).
        /// </summary>
        [JsonConverter(typeof(DecimalToIntegerConverter))]
        public decimal Amount { get; set; }

        /// <summary>
        ///     Moeda na qual o pagamento ser� feito (BRL).
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Currency? Currency { get; set; }

        /// <summary>
        ///     Define comportamento do meio de pagamento (https://developercielo.github.io/Webservice-3.0/#lista-de-providers)
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Provider? Provider { get; set; }

        /// <summary>
        ///     Total da transa��o que deve ser destinado ao pagamento da taxa de embarque � Infraero. O valor da taxa de embarque
        ///     n�o � acumulado ao valor da autoriza��o.
        /// </summary>
        [JsonConverter(typeof(DecimalToIntegerConverter))]
        public decimal? ServiceTaxAmount { get; set; }

        /// <summary>
        ///     N�mero de Parcelas.
        /// </summary>
        public short? Installments { get; set; }

        /// <summary>
        ///     Tipo de parcelamento - Loja (ByMerchant) ou Cart�o (ByIssuer).
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentInterest? Interest { get; set; }

        /// <summary>
        ///     Booleano que identifica que a autoriza��o deve ser com captura autom�tica.
        /// </summary>
        public bool? Capture { get; set; }

        /// <summary>
        ///     Define se o comprador ser� direcionado ao banco emissor para autentica��o do cart�o
        /// </summary>
        public bool? Authenticate { get; set; }
        public bool? Recurrent { get; set; }
        public RecurrentPayment RecurrentPayment { get; set; }
        public CreditCard CreditCard { get; set; }
        public DebitCard DebitCard { get; set; }
        [JsonProperty("Tid")]
        public string TransactionId { get; set; }
        public string ProofOfSale { get; set; }
        public string AuthorizationCode { get; set; }
        public string SoftDescriptor { get; set; }
        public string ReturnUrl { get; set; }
        [JsonProperty("PaymentId")]
        public Guid Id { get; set; }
        public DateTime? ReceivedDate { get; set; }
        [JsonConverter(typeof(DecimalToIntegerConverter))]
        public decimal? CapturedAmount { get; set; }
        public DateTime? CapturedDate { get; set; }
        public string Country { get; set; }
        [JsonProperty("ReturnCode")]
        [JsonConverter(typeof(PaymentReturnConverter))]
        public PaymentReturn Return { get; set; }
        [JsonConverter(typeof(PaymentStatusConverter))]
        public PaymentStatus Status { get; set; }
        public List<Link> Links { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Url { get; set; }
        public string Number { get; set; }
        public string BarCodeNumber { get; set; }
        public string DigitableLine { get; set; }
        public string Address { get; set; }
        public string BoletoNumber { get; set; }
        public string Assignor { get; set; }
        public string Demonstrative { get; set; }
        public string Identification { get; set; }
        public string Instructions { get; set; }
        public string AuthenticationUrl { get; set; }
    }
}   