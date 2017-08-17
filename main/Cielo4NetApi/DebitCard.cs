﻿using Cielo4NetApi.Converters;
using Cielo4NetApi.Enumerators;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cielo4NetApi
{
    public class DebitCard
    {
        /// <summary>
        ///     Número do Cartão do Comprador.
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        ///     Nome do Comprador impresso no cartão.
        /// </summary>
        public string Holder { get; set; }

        /// <summary>
        ///     Data de validade impresso no cartão.
        /// </summary>
        public string ExpirationDate { get; set; }

        /// <summary>
        ///     Código de segurança impresso no verso do cartão
        /// </summary>
        public string SecurityCode { get; set; }

        /// <summary>
        ///     Bandeira do cartão
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public DebitCardBrand Brand { get; set; }
    }
}