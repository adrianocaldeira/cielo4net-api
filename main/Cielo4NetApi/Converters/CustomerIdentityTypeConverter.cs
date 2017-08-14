﻿using System;
using Newtonsoft.Json;

namespace Cielo4NetApi.Converters
{
    /// <summary>
    ///     Conversor JSON do tipo de identificação do comprador
    /// </summary>
    public class CustomerIdentityTypeConverter : JsonConverter
    {
        /// <summary>Writes the JSON representation of the object.</summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var customerIdentityType = (CustomerIdentityType) value;

            switch (customerIdentityType)
            {
                case CustomerIdentityType.None:
                    writer.WriteValue("");
                    break;
                case CustomerIdentityType.Cpf:
                    writer.WriteValue("CPF");
                    break;
                case CustomerIdentityType.Cnpj:
                    writer.WriteValue("CNPJ");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>Reads the JSON representation of the object.</summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var enumString = (string) reader.Value;

            return Enum.Parse(typeof(CustomerIdentityType), enumString, true);
        }

        /// <summary>
        ///     Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        ///     <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}