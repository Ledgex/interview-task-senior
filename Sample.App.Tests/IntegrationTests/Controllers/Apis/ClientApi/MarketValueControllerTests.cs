using Sample.App.Controllers.ClientApp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Sample.App.DataAccess;
using System.Threading.Tasks;
using Sample.App.Common.DTOs;
using System.Collections.Generic;
using Sample.App.BusinessServices.Services.TransactionService;

namespace Sample.App.Tests.IntegrationTests.Controllers.Apis.ClientApi
{
    [TestFixture]
    public class MarketValueControllerTests : IntegrationTestsBase
    {
        private MarketValueController _controller;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var persistence = new TenantPersistence();
            var service = new MarketValueService(persistence);

            _controller = new MarketValueController(service)
            {
                ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext()
                }
            };
        }

        [Test]
        public async Task GetAllAsync_NoArgs_ReturnsAllMarketValues()
        {
            var result = await _controller.GetAllAsync();
            var resultList = AssertResponseIs<OkObjectResult, List<MarketValueDTO>>(result);
            Assert.AreEqual(5, resultList.Count);
        }
    }
}
