﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RestSharp;

namespace Cielo4NetApi.Request
{
public abstract class AbstractSaleRequest<TRequest, TResponse> where TResponse : new()
    {
        protected AbstractSaleRequest(Merchant merchant, Environment environment)
        {
            Merchant = merchant;
            Environment = environment;
        }

        public Merchant Merchant { get; }
        public Environment Environment { get; }

        public abstract CieloResponse<TResponse> Execute(TRequest parameter);

        public CieloResponse<TResponse> Send(RestClient client, RestRequest request, string parseJsonOfSpecificPropertyName = null)
        {
            request.AddHeader("User-Agent", "CieloEcommerce/3.0 .NET SDK");
            request.AddHeader("MerchantId", Merchant.Id);
            request.AddHeader("MerchantKey", Merchant.Key);
            request.AddHeader("RequestId", Guid.NewGuid().ToString("N"));

            var response = client.Execute(request);
            
            return Parse((int)response.StatusCode, response.Content, parseJsonOfSpecificPropertyName);
        }

        private static CieloResponse<TResponse> Parse(int statusCode, string content, string parseJsonOfSpecificPropertyName)
        {
            var response = default(TResponse);
            var errors = new List<CieloError>();

            switch (statusCode)
            {
                case 200:
                case 201:
                    response = string.IsNullOrWhiteSpace(parseJsonOfSpecificPropertyName) ? 
                        JsonConvert.DeserializeObject<TResponse>(content) : 
                        DeserializeSpecificProperty<TResponse>(parseJsonOfSpecificPropertyName, content);
                    
                    break;
                case 400:
                    errors.AddRange(JsonConvert.DeserializeObject<List<CieloError>>(content));
                    break;
                case 404:
                    throw new CieloRequestException(404, "Not found");
                default:
                    errors.Add(new CieloError(0, $"Unknown status {statusCode}"));
                    break;
            }

            return new CieloResponse<TResponse>(response, errors);
        }

        public static T DeserializeSpecificProperty<T>(string propertyName, string json)
        {
            using (var stringReader = new StringReader(json))
            {
                using (var jsonReader = new JsonTextReader(stringReader))
                {
                    while (jsonReader.Read())
                    {
                        if (jsonReader.TokenType == JsonToken.PropertyName
                            && (string)jsonReader.Value == propertyName)
                        {
                            jsonReader.Read();

                            var serializer = new JsonSerializer();
                            return serializer.Deserialize<T>(jsonReader);
                        }
                    }
                    return default(T);
                }
            }
        }
    }
}
