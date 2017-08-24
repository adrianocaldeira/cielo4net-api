using Cielo4NetApi.Services;
using NUnit.Framework;

namespace Cielo4NetApi
{
    [TestFixture]
    public class MerchantOrderServiceTest
    {
        private MerchantOrderService Service { get; set; }

        [SetUp]
        protected void SetUp()
        {
            Service = new MerchantOrderService();
        }

        [Test]
        public void List()
        {
            var response = Service.List("123456");

            Assert.IsFalse(response.HasErrors, "Não deve conter erros");
            Assert.IsNotNull(response.Response, "Resposta não pode ser nula");
            Assert.IsNotEmpty(response.Response, "Tem que ter algum item na listagem");
        }
    }
}