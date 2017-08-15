using System;
using System.Collections.Generic;
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
        public PaymentInterest Interest { get; set; }

        /// <summary>
        ///     Booleano que identifica que a autoriza��o deve ser com captura autom�tica.
        /// </summary>
        public bool Capture { get; set; }

        /// <summary>
        ///     Define se o comprador ser� direcionado ao banco emissor para autentica��o do cart�o
        /// </summary>
        public bool Authenticate { get; set; }
        public bool Recurrent { get; set; }
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
        public string Id { get; set; }
        public string ReceivedDate { get; set; }
        public int CapturedAmount { get; set; }
        public string CapturedDate { get; set; }
        public string Country { get; set; }
        public string ReturnCode { get; set; }
        public string ReturnMessage { get; set; }
        public string Status { get; set; }
        public List<Link> Links { get; set; }
        public DateTime ExpirationDate { get; set; }
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