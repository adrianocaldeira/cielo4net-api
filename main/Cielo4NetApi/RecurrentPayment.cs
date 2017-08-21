using System;
using System.Collections.Generic;
using Cielo4NetApi.Converters;
using Cielo4NetApi.Enumerators;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cielo4NetApi
{
    public class RecurrentPayment
    {
        [JsonProperty("RecurrentPaymentId")]
        public Guid Id { get; set; }
        public DateTime? NextRecurrency { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public RecurrentPaymentInterval Interval { get; set; }
        [JsonConverter(typeof(DecimalToIntegerConverter))]
        public decimal? Amount { get; set; }
        public string Country { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Currency { get; set; }
        public int? CurrentRecurrencyTry { get; set; }
        public string Provider { get; set; }
        public int? RecurrencyDay { get; set; }
        public int? SuccessfulRecurrences { get; set; }
        public bool AuthorizeNow { get; set; }
        public int? ReasonCode { get; set; }
        public string ReasonMessage { get; set; }
        public int? Status { get; set; }
        public List<Link> Links { get; set; }
        public List<RecurrentTransaction> RecurrentTransactions { get; set; }
    }

    public class RecurrentTransaction
    {
        public string PaymentId { get; set; }
        public int PaymentNumber { get; set; }
        public int TryNumber { get; set; }
    }
}
