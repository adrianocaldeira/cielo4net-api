using System;
using Newtonsoft.Json;

namespace Cielo4NetApi.Converters
{
    internal class PaymentStatusConverter : JsonConverter
    {
        /// <summary>Writes the JSON representation of the object.</summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((PaymentStatus)value).Code);
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
                case 0:
                    return new PaymentStatus
                    {
                        Code = statusCode,
                        Name = "NotFinished",
                        Message = "	Aguardando atualização de status"
                    };
                case 1:
                    return new PaymentStatus
                    {
                        Code = statusCode,
                        Name = "Authorized",
                        Message = "	Pagamento apto a ser capturado ou definido como pago"
                    };
                case 2:
                    return new PaymentStatus
                    {
                        Code = statusCode,
                        Name = "PaymentConfirmed",
                        Message = "Pagamento confirmado e finalizado"
                    };
                case 3:
                    return new PaymentStatus
                    {
                        Code = statusCode,
                        Name = "Denied",
                        Message = "Pagamento negado por Autorizador"
                    };
                case 10:
                    return new PaymentStatus
                    {
                        Code = statusCode,
                        Name = "Voided",
                        Message = "Pagamento cancelado"
                    };
                case 11:
                    return new PaymentStatus
                    {
                        Code = statusCode,
                        Name = "Refunded",
                        Message = "Pagamento cancelado após 23:59 do dia de autorização"
                    };
                case 12:
                    return new PaymentStatus
                    {
                        Code = statusCode,
                        Name = "Pending",
                        Message = "	Aguardando Status de instituição financeira"
                    };
                case 13:
                    return new PaymentStatus
                    {
                        Code = statusCode,
                        Name = "Aborted",
                        Message = "Pagamento cancelado por falha no processamento"
                    };
                case 14:
                    return new PaymentStatus
                    {
                        Code = statusCode,
                        Name = "Scheduled",
                        Message = "Recorrência agendada"
                    };
                default:
                    return new PaymentStatus { Code = statusCode, Name = "Não implementado", Message = "Código de status não implementado"};
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