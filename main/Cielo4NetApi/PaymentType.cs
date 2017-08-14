namespace Cielo4NetApi
{
    /// <summary>
    ///     Tipo de pagamento
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        ///     Cartão de crédito
        /// </summary>
        CreditCard,

        /// <summary>
        ///     Cartão de Débito
        /// </summary>
        DebitCard,

        /// <summary>
        ///     Boleto
        /// </summary>
        Boleto,

        /// <summary>
        ///     Transferência Eletrônica
        /// </summary>
        EletronicTransfer
    }
}