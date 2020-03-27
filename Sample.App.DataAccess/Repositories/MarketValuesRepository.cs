using Sample.App.Common.DataAccess;
using Sample.App.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.App.DataAccess.Repositories
{
    public class MarketValuesRepository : IMarketValueRepository
    {
        public async Task<List<MarketValueDTO>> GetMarketValuesAsync()
        {
            var fakeMarketValues = new List<MarketValueDTO> {
                new MarketValueDTO(new DateTime(2020, 4, 2), "CVCII", 32818, .9),
                new MarketValueDTO(new DateTime(2020, 3, 15), "TSLA", 9, 1.2),
                new MarketValueDTO(new DateTime(2020, 4, 2), "BABA", 51281, -1.3),
                new MarketValueDTO(new DateTime(2020, 4, 14), "VZ", 34212, 0),
                new MarketValueDTO(new DateTime(2020, 3, 10), "TSLA", 435103, -.05),
            };

            // Simulated fake db call
            return await Task.Run(() => fakeMarketValues.OrderBy(mv => mv.InvestmentSymbol).ThenBy(mv => mv.AsOfDate).ToList());
        }
    }
}
