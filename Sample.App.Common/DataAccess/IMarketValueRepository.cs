using Sample.App.Common.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.App.Common.DataAccess
{
    public interface IMarketValueRepository
    {
        Task<List<MarketValueDTO>> GetMarketValuesAsync();
    }
}
