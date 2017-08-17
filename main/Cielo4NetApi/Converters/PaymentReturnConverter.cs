using System;
using Newtonsoft.Json;

namespace Cielo4NetApi.Converters
{
    internal class PaymentReturnConverter : JsonConverter
    {
        /// <summary>Writes the JSON representation of the object.</summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((PaymentReturn)value).Code);
        }

        /// <summary>Reads the JSON representation of the object.</summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var statusCode = Convert.ToInt16(reader.Value);

            switch (statusCode)
            {
                case 4:
                case 6:
                    return new PaymentReturn
                    {
                        Code = statusCode,
                        Name = "Autorizado",
                        Message = "Operação realizada com sucesso"
                    };
                case 2:
                    return new PaymentReturn
                    {
                        Code = statusCode,
                        Name = "Não Autorizada",
                        Message = "Não Autorizada"
                    };
                case 77:
                    return new PaymentReturn
                    {
                        Code = statusCode,
                        Name = "Não Autorizado",
                        Message = "Cartão Cancelado"
                    };
                case 70:
                    return new PaymentReturn
                    {
                        Code = statusCode,
                        Name = "Não Autorizado",
                        Message = "Problemas com o Cartão de Crédito"
                    };
                case 78:
                    return new PaymentReturn
                    {
                        Code = statusCode,
                        Name = "Não Autorizado",
                        Message = "Cartão Bloqueado"
                    };
                case 99:
                    return new PaymentReturn
                    {
                        Code = statusCode,
                        Name = "Não Autorizado",
                        Message = "Time Out"
                    };
                default:
                    return new PaymentReturn{Code = statusCode, Name = "Não implementado", Message = "Código de status não implementado"};
            }
        }

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// 	<c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}