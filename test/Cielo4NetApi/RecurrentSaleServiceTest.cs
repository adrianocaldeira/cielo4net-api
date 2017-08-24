using System;
using Cielo4NetApi.Enumerators;
using Cielo4NetApi.Services;
using NUnit.Framework;

namespace Cielo4NetApi
{
    [TestFixture]
    public class RecurrentSaleServiceTest
    {
        private RecurrentSaleService Service { get; set; }
        private SaleService SaleService { get; set; }

        [SetUp]
        protected void SetUp()
        {
            //var merchant = new Merchant("7b47a500-fece-487b-ae02-5ef034a9fc1d", "UOXJOMKHNRLNXFTVNRJHUTNMPVMFLOKVDRQZKZLE");
            //var environment = Environment.Sandbox();

            Service = new RecurrentSaleService();
            SaleService = new SaleService();
        }

        [Test]
        public void Get()
        {
            var id = Guid.NewGuid().ToString("N");
            var saleResponse = SaleService.Create(new Sale
            {
                Id = id,
                Payment = new Payment
                {
                    Type = PaymentType.CreditCard,
                    Amount = 157.57M,
                    Installments = 1,
                    SoftDescriptor = "123456789ABCD",
                    CreditCard = new CreditCard
                    {
                        CardNumber = "1234123412341231",
                        Holder = "Adriano H Caldeira",
                        ExpirationDate = new DateTime(2023, 1, 1),
                        SecurityCode = "123",
                        Brand = CreditCardBrand.Visa,
                        SaveCard = true
                    },
                    Capture = true,
                    RecurrentPayment = new RecurrentPayment
                    {
                        AuthorizeNow = true, 
                        EndDate = DateTime.Now.AddYears(1).Date,
                        Interval = RecurrentPaymentInterval.Quarterly 
                    } 
                },
                Customer = new Customer
                {
                    Name = "Adriano"
                }
            });

            var response = Service.Get(saleResponse.Response.Payment.RecurrentPayment.Id);

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }

        [Test]
        public void Deactivate()
        {
            var id = Guid.NewGuid().ToString("N");
            var saleResponse = SaleService.Create(new Sale
            {
                Id = id,
                Payment = new Payment
                {
                    Type = PaymentType.CreditCard,
                    Amount = 157.57M,
                    Installments = 1,
                    SoftDescriptor = "123456789ABCD",
                    CreditCard = new CreditCard
                    {
                        CardNumber = "1234123412341231",
                        Holder = "Adriano H Caldeira",
                        ExpirationDate = new DateTime(2023, 1, 1),
                        SecurityCode = "123",
                        Brand = CreditCardBrand.Visa,
                        SaveCard = true
                    },
                    Capture = true,
                    RecurrentPayment = new RecurrentPayment
                    {
                        AuthorizeNow = true, 
                        EndDate = DateTime.Now.AddYears(1).Date,
                        Interval = RecurrentPaymentInterval.Monthly 
                    } 
                },
                Customer = new Customer
                {
                    Name = "Adriano"
                }
            });

            var response = Service.Deactivate(saleResponse.Response.Payment.RecurrentPayment.Id);

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }
    }
}
