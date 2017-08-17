using System.Runtime.Serialization;

namespace Cielo4NetApi.Enumerators
{
    /// <summary>
    ///     Tipo de pagamento
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        ///     Cart�o de cr�dito
        /// </summary>
        [EnumMember(Value = "CreditCard")]
        CreditCard,

        /// <summary>
        ///     Cart�o de D�bito
        /// </summary>
        [EnumMember(Value = "DebitCard")]
        DebitCard,

        /// <summary>
        ///     Boleto
        /// </summary>
        [EnumMember(Value = "Boleto")]
        Boleto,

        /// <summary>
        ///     Transfer�ncia Eletr�nica
        /// </summary>
        [EnumMember(Value = "EletronicTransfer")]
        EletronicTransfer
    }
}