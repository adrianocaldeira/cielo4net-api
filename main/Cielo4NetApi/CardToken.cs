﻿using System;
using Cielo4NetApi.Converters;
using Cielo4NetApi.Enumerators;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cielo4NetApi
{
    public class CardToken
    {
        /// <summary>
        ///     Bandeira do cartão
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CreditCardBrand Brand { get; set; }

        /// <summary>
        ///     Número do Cartão do Comprador.
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        ///     Token de identificação do Cartão.
        /// </summary>
        [JsonProperty("CardToken")]
        public Guid Token { get; set; }

        /// <summary>
        /// </summary>
        public string CustomerName { get; set; }

        [JsonConverter(typeof(CreditCardExpirationDateConverter))]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// </summary>
        public string Holder { get; set; }

        [JsonProperty("Links")]
        public Link Link { get; set; }
    }
}