using Sample.App.Common.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.App.BusinessServices.Services.TransactionService
{
    public interface IMarketValueService
    {
        Task<List<MarketValueDTO>> GetMarketValues();
    }
}
