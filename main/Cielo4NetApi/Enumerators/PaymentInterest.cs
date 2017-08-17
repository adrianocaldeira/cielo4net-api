using System.Runtime.Serialization;

namespace Cielo4NetApi.Enumerators
{
    /// <summary>
    ///     Tipo do parcelamento do pagamento
    /// </summary>
    public enum PaymentInterest
    {
        /// <summary>
        ///     Loja
        /// </summary>
        [EnumMember(Value = "ByMerchant")]
        Merchant,

        /// <summary>
        ///     Cartão
        /// </summary>
        [EnumMember(Value = "ByIssuer")]
        Issuer
    }
}