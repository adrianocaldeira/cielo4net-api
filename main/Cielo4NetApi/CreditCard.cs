﻿using System;
using Cielo4NetApi.Converters;
using Cielo4NetApi.Enumerators;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cielo4NetApi
{
    /// <summary>
    ///     Cartão do Comprador
    /// </summary>
    public class CreditCard
    {
        /// <summary>
        ///     Número do Cartão do Comprador.
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        ///     Nome do Comprador impresso no cartão.
        /// </summary>
        public string Holder { get; set; }

        [JsonConverter(typeof(CreditCardExpirationDateConverter))]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        ///     Código de segurança impresso no verso do cartão
        /// </summary>
        public string SecurityCode { get; set; }

        /// <summary>
        ///     Booleano que identifica se o cartão será salvo para gerar o CardToken.
        /// </summary>
        public bool? SaveCard { get; set; }

        /// <summary>
        ///     Bandeira do cartão
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CreditCardBrand Brand { get; set; }

        /// <summary>
        ///     Token de identificação do Cartão.
        /// </summary>
        public Guid? CardToken { get; set; }
    }
}