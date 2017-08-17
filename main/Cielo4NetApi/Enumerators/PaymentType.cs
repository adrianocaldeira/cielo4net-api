using System.Runtime.Serialization;

namespace Cielo4NetApi.Enumerators
{
    /// <summary>
    ///     Tipo de pagamento
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        ///     Cartão de crédito
        /// </summary>
        [EnumMember(Value = "CreditCard")]
        CreditCard,

        /// <summary>
        ///     Cartão de Débito
        /// </summary>
        [EnumMember(Value = "DebitCard")]
        DebitCard,

        /// <summary>
        ///     Boleto
        /// </summary>
        [EnumMember(Value = "Boleto")]
        Boleto,

        /// <summary>
        ///     Transferência Eletrônica
        /// </summary>
        [EnumMember(Value = "EletronicTransfer")]
        EletronicTransfer
    }
}