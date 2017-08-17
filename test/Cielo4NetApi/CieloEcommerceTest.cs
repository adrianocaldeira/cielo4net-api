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
                MerchantOrderId = "123456",
                Payment = new Payment
                {
                    Type = PaymentType.CreditCard,
                    Amount = 157.57M,
                    Installments = 1,
                    SoftDescriptor = "123456789ABCD",
                    CreditCard = new CreditCard
                    {
                        CardNumber = "1234123412341231",
                        Holder = "Teste Holder",
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
        }
    }
}
