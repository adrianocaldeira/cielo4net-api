using System;
using Newtonsoft.Json;

namespace Cielo4NetApi.Converters
{
    /// <summary>
    ///     Conversor JSON do tipo de pagamento
    /// </summary>
    public class PaymentTypeConverter : JsonConverter
    {
        /// <summary>Writes the JSON representation of the object.</summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var paymentType = (PaymentType) value;

            switch (paymentType)
            {
                case PaymentType.CreditCard:
                    writer.WriteValue("CreditCard");
                    break;
                case PaymentType.DebitCard:
                    writer.WriteValue("DebitCard");
                    break;
                case PaymentType.Boleto:
                    writer.WriteValue("Boleto");
                    break;
                case PaymentType.EletronicTransfer:
                    writer.WriteValue("EletronicTransfer");
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

            return Enum.Parse(typeof(PaymentType), enumString, true);
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