using System;
using Cielo4NetApi.Enumerators;
using Cielo4NetApi.Services;
using NUnit.Framework;

namespace Cielo4NetApi
{
    [TestFixture]
    public class CardTokenServiceTest
    {
        [SetUp]
        protected void SetUp()
        {
            Service = new CardTokenService();
        }

        private CardTokenService Service { get; set; }

        [Test]
        public void CreateCardToken()
        {
            var response = Service.Create(new CardToken
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
    }
}