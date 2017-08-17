using Newtonsoft.Json.Converters;

namespace Cielo4NetApi.Converters
{
    internal class DateConverter : IsoDateTimeConverter
    {
        public DateConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}