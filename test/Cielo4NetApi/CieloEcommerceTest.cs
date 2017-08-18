using System;
using Cielo4NetApi.Enumerators;
using NUnit.Framework;

namespace Cielo4NetApi
{
    [TestFixture]
    public class CieloEcommerceTest
    {
        private CieloEcommerce Instance { get; set; }

        [SetUp]
        protected void SetUp()
        {
            Instance = new CieloEcommerce(new Merchant("7b47a500-fece-487b-ae02-5ef034a9fc1d", "UOXJOMKHNRLNXFTVNRJHUTNMPVMFLOKVDRQZKZLE"), 
                Environment.Sandbox());
        }

        [Test]
        public void CreateSale()
        {
            var response = Instance.CreateSale(new Sale
            {
                Id = "123456",
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
                    Capture = true
                },
                Customer = new Customer
                {
                    Name = "Adriano"
                }
            });

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }

        [Test]
        public void CreateCardToken()
        {
            var response = Instance.CreateCardToken(new CardToken
            {
                Brand = CreditCardBrand.Visa,
                CardNumber = "1234123412341231",
                CustomerName = "Adriano Caldeira",
                ExpirationDate = DateTime.Now.AddYears(3),
                Holder = "Adriano H Caldeira"
            });

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }

        [Test]
        public void QuerySaleByGuid()
        {
            var response = Instance.QuerySale(new Guid("fd29ddba-34e1-4509-b98d-09d68f3365c2"));

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
            Assert.AreEqual(response.Response.Payment.TransactionId, "0818111609123", "Código de transação tem que ser igual a 0818111609123");
        }

        [Test]
        public void QueryMerchantOrder()
        {
            var response = Instance.QueryMerchantOrder("123456");

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
            Assert.IsNotEmpty(response.Response, "Tem que ter algum item na listagem");
        }

        [Test]
        public void CancelSale()
        {
            var id = Guid.NewGuid().ToString("N");
            var saleResponse = Instance.CreateSale(new Sale
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
                    Capture = true
                },
                Customer = new Customer
                {
                    Name = "Adriano"
                }
            });

            var response = Instance.CancelSale(saleResponse.Response.Payment.Id);

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }

        [Test]
        public void CancelSaleWithAmout()
        {
            var id = Guid.NewGuid().ToString("N");
            var saleResponse = Instance.CreateSale(new Sale
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
                    Capture = true
                },
                Customer = new Customer
                {
                    Name = "Adriano"
                }
            });

            var response = Instance.CancelSale(saleResponse.Response.Payment.Id, 157.57M);

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }

        [Test]
        public void CancelSaleWithAmoutAndServiceTaxAmount()
        {
            var id = Guid.NewGuid().ToString("N");
            var saleResponse = Instance.CreateSale(new Sale
            {
                Id = id,
                Payment = new Payment
                {
                    Type = PaymentType.CreditCard,
                    Amount = 157.57M,
                    Installments = 3,
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
                    ServiceTaxAmount = 12.75M
                },
                Customer = new Customer
                {
                    Name = "Adriano"
                }
            });

            var response = Instance.CancelSale(saleResponse.Response.Payment.Id, 157.57M, 12.75M);

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }
    }
}
