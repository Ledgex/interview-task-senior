using Microsoft.AspNetCore.Mvc;
using Sample.App.BusinessServices.Services.TransactionService;
using System.Threading.Tasks;

namespace Sample.App.Controllers.ClientApp
{
    [Route("api/[controller]")]
    public class MarketValueController : Controller
    {
        private IMarketValueService _service;

        public MarketValueController(IMarketValueService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var results = await _service.GetMarketValues();
            return Ok(results);
        }
    }
}
