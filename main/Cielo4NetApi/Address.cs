namespace Cielo4NetApi
{
    /// <summary>
    ///     Endereço do comprador
    /// </summary>
    public class Address
    {
        /// <summary>
        ///     Endereço do Comprador.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        ///     Número do endereço do Comprador.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        ///     Complemento do endereço do Comprador.
        /// </summary>
        public string Complement { get; set; }

        /// <summary>
        ///     CEP do endereço do Comprador.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        ///     Cidade do endereço do Comprador.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        ///     Estado do endereço do Comprador.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        ///     Pais do endereço do Comprador.
        /// </summary>
        public string Country { get; set; }
    }
}