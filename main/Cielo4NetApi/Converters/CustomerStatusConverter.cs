using System;
using Newtonsoft.Json;

namespace Cielo4NetApi.Converters
{
    /// <summary>
    ///     Conversor JSON do status do comprador
    /// </summary>
    public class CustomerStatusConverter : JsonConverter
    {
        /// <summary>Writes the JSON representation of the object.</summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var customerStatus = (CustomerStatus) value;

            switch (customerStatus)
            {
                case CustomerStatus.New:
                    writer.WriteValue("NEW");
                    break;
                case CustomerStatus.Existing:
                    writer.WriteValue("EXISTING");
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

            return Enum.Parse(typeof(CustomerStatus), enumString, true);
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