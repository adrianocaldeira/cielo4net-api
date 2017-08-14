using System;
using Cielo4NetApi.Converters;
using Newtonsoft.Json;

namespace Cielo4NetApi
{
    /// <summary>
    ///     Comprador
    /// </summary>
    public class Customer
    {
        /// <summary>
        ///     Nome do Comprador
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Status de cadastro do comprador na loja
        /// </summary>
        [JsonConverter(typeof(CustomerStatusConverter))]
        public CustomerStatus Status { get; set; }

        /// <summary>
        ///     Número do RG, CPF ou CNPJ do Cliente.
        /// </summary>
        public string Identity { get; set; }

        /// <summary>
        ///     Tipo de documento de identificação do comprador (CFP/CNPJ).
        /// </summary>
        [JsonConverter(typeof(CustomerIdentityTypeConverter))]
        public CustomerIdentityType IdentityType { get; set; }

        /// <summary>
        ///     Email do Comprador.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///     Data de nascimento do Comprador.
        /// </summary>
        public DateTime Birthdate { get; set; }

        /// <summary>
        ///     Endereço do comprador
        /// </summary>
        public CustomerAddress Address { get; set; }

        /// <summary>
        ///     Endereço de entrega do comprador
        /// </summary>
        public CustomerAddress DeliveryAddress { get; set; }
    }
}