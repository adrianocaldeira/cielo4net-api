using System;
using Cielo4NetApi.Enumerators;
using Cielo4NetApi.Services;
using NUnit.Framework;

namespace Cielo4NetApi
{
    [TestFixture]
    public class SaleServiceTest
    {
        [SetUp]
        protected void SetUp()
        {
            Service = new SaleService(new Merchant("7b47a500-fece-487b-ae02-5ef034a9fc1d", "UOXJOMKHNRLNXFTVNRJHUTNMPVMFLOKVDRQZKZLE"),
                Environment.Sandbox());
        }
        
        private SaleService Service { get; set; }

        [Test]
        public void Create()
        {
            var response = Service.Create(new Sale
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
        public void Get()
        {
            var response = Service.Get(new Guid("fd29ddba-34e1-4509-b98d-09d68f3365c2"));

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
            Assert.AreEqual(response.Response.Payment.TransactionId, "0818111609123", "Código de transação tem que ser igual a 0818111609123");
        }

        [Test]
        public void Cancel()
        {
            var id = Guid.NewGuid().ToString("N");
            var saleResponse = Service.Create(new Sale
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

            var response = Service.Cancel(saleResponse.Response.Payment.Id);

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }


        [Test]
        public void CancelWithAmout()
        {
            var id = Guid.NewGuid().ToString("N");
            var saleResponse = Service.Create(new Sale
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

            var response = Service.Cancel(saleResponse.Response.Payment.Id, 157.57M);

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }

        [Test]
        public void CancelWithAmoutAndServiceTaxAmount()
        {
            var id = Guid.NewGuid().ToString("N");
            var saleResponse = Service.Create(new Sale
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

            var response = Service.Cancel(saleResponse.Response.Payment.Id, 157.57M, 12.75M);

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }

        [Test]
        public void Capture()
        {
            var id = Guid.NewGuid().ToString("N");
            var saleResponse = Service.Create(new Sale
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
                    }
                },
                Customer = new Customer
                {
                    Name = "Adriano"
                }
            });

            var response = Service.Capture(saleResponse.Response.Payment.Id);

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }


        [Test]
        public void CaptureWithAmout()
        {
            var id = Guid.NewGuid().ToString("N");
            var saleResponse = Service.Create(new Sale
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
                    }
                },
                Customer = new Customer
                {
                    Name = "Adriano"
                }
            });

            var response = Service.Capture(saleResponse.Response.Payment.Id, 157.57M);

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }

        [Test]
        public void CaptureSaleWithAmoutAndServiceTaxAmount()
        {
            var id = Guid.NewGuid().ToString("N");
            var saleResponse = Service.Create(new Sale
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
                    ServiceTaxAmount = 12.75M
                },
                Customer = new Customer
                {
                    Name = "Adriano"
                }
            });

            var response = Service.Capture(saleResponse.Response.Payment.Id, 157.57M, 12.75M);

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
        }
    }
}