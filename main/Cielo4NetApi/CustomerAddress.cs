namespace Cielo4NetApi
{
    /// <summary>
    ///     Endere�o do comprador
    /// </summary>
    public class CustomerAddress
    {
        /// <summary>
        ///     Endere�o do Comprador.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        ///     N�mero do endere�o do Comprador.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        ///     Complemento do endere�o do Comprador.
        /// </summary>
        public string Complement { get; set; }

        /// <summary>
        ///     CEP do endere�o do Comprador.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        ///     Cidade do endere�o do Comprador.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        ///     Estado do endere�o do Comprador.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        ///     Pais do endere�o do Comprador.
        /// </summary>
        public string Country { get; set; }
    }
}