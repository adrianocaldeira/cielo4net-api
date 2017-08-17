using System.IO;
using Newtonsoft.Json;
using RestSharp.Serializers;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Cielo4NetApi
{
    public class CieloJsonSerializer : ISerializer
    {
        private readonly JsonSerializer _serializer;

        /// <summary>
        ///     Default serializer
        /// </summary>
        public CieloJsonSerializer()
        {
            ContentType = "application/json";
            _serializer = new JsonSerializer
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Include
            };
        }

        /// <summary>
        ///     Default serializer with overload for allowing custom Json.NET settings
        /// </summary>
        public CieloJsonSerializer(JsonSerializer serializer)
        {
            ContentType = "application/json";
            _serializer = serializer;
        }

        public string Serialize(object obj)
        {
            using (var stringWriter = new StringWriter())
            {
                using (var jsonTextWriter = new JsonTextWriter(stringWriter))
                {
                    jsonTextWriter.Formatting = Formatting.Indented;
                    jsonTextWriter.QuoteChar = '"';

                    _serializer.Serialize(jsonTextWriter, obj);

                    var result = stringWriter.ToString();
                    return result;
                }
            }
        }

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }
        public string ContentType { get; set; }
    }
}