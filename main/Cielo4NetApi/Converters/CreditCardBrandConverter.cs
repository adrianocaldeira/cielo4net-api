using System;
using Newtonsoft.Json;

namespace Cielo4NetApi.Converters
{
    /// <summary>
    ///     Conversor JSON da bandeira do cartão do comprador
    /// </summary>
    public class CreditCardBrandConverter : JsonConverter
    {
        /// <summary>Writes the JSON representation of the object.</summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var creditCardBrand = (CreditCardBrand) value;

            switch (creditCardBrand)
            {
                case CreditCardBrand.Amex:
                    writer.WriteValue("Amex");
                    break;
                case CreditCardBrand.Aura:
                    writer.WriteValue("Aura");
                    break;
                case CreditCardBrand.Diners:
                    writer.WriteValue("Diners");
                    break;
                case CreditCardBrand.Visa:
                    writer.WriteValue("Visa");
                    break;
                case CreditCardBrand.Master:
                    writer.WriteValue("Master");
                    break;
                case CreditCardBrand.Elo:
                    writer.WriteValue("Elo");
                    break;
                case CreditCardBrand.Jcb:
                    writer.WriteValue("JCB");
                    break;
                case CreditCardBrand.Discover:
                    writer.WriteValue("Discover");
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

            return Enum.Parse(typeof(CreditCardBrand), enumString, true);
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