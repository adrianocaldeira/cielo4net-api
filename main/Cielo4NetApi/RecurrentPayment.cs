using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cielo4NetApi
{
    public class RecurrentPayment
    {
        public string RecurrentPaymentId { get; set; }
        public string NextRecurrency { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Interval { get; set; }
        public int Amount { get; set; }
        public string Country { get; set; }
        public string CreateDate { get; set; }
        public string Currency { get; set; }
        public int CurrentRecurrencyTry { get; set; }
        public string Provider { get; set; }
        public int RecurrencyDay { get; set; }
        public int SuccessfulRecurrences { get; set; }
        public bool AuthorizeNow { get; set; }
        public int ReasonCode { get; set; }
        public string ReasonMessage { get; set; }
        public int Status { get; set; }
        public List<Link> Links { get; set; }
        public RecurrentTransaction RecurrentTransactions { get; set; }
    }

    public class RecurrentSale
    {
        public Customer Customer { get; set; }
        public RecurrentPayment RecurrentPayment { get; set; }
    }

    public class RecurrentTransaction
    {
        public string PaymentId { get; set; }
        public int PaymentNumber { get; set; }
        public int TryNumber { get; set; }
    }
}
