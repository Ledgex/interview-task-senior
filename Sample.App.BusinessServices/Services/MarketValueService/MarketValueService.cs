using Sample.App.Common.DataAccess;
using Sample.App.Common.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.App.BusinessServices.Services.TransactionService
{
    public class MarketValueService : IMarketValueService
    {
        private readonly ITenantPersistence _persistence;

        public MarketValueService(ITenantPersistence persistence)
            : base()
        {
            _persistence = persistence;
        }

        public async Task<List<MarketValueDTO>> GetMarketValues()
        {
            return await _persistence.MarketValues.GetMarketValuesAsync();
        }
    }
}
