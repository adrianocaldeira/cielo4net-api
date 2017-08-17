using Newtonsoft.Json.Converters;

namespace Cielo4NetApi.Converters
{
    internal class CreditCardExpirationDateConverter : IsoDateTimeConverter
    {
        public CreditCardExpirationDateConverter()
        {
            DateTimeFormat = "MM/yyyy";
        }
    }
}
