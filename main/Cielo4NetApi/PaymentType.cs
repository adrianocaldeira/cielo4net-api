namespace Cielo4NetApi
{
    /// <summary>
    ///     Tipo de pagamento
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        ///     Cart�o de cr�dito
        /// </summary>
        CreditCard,

        /// <summary>
        ///     Cart�o de D�bito
        /// </summary>
        DebitCard,

        /// <summary>
        ///     Boleto
        /// </summary>
        Boleto,

        /// <summary>
        ///     Transfer�ncia Eletr�nica
        /// </summary>
        EletronicTransfer
    }
}