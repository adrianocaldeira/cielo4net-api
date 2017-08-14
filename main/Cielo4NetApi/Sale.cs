namespace Cielo4NetApi
{
    /// <summary>
    ///     Venda
    /// </summary>
    public class Sale
    {
        /// <summary>
        ///     Numero de identificação do Pedido.
        /// </summary>
        public string MerchantOrderId { get; set; }

        /// <summary>
        ///     Comprador
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        ///     Pagamento
        /// </summary>
        public Payment Payment { get; set; }
    }
}