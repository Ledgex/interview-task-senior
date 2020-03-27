using Sample.App.Common.DataAccess;
using Sample.App.DataAccess.Repositories;

namespace Sample.App.DataAccess
{
    public class TenantPersistence : ITenantPersistence
    {
        public TenantPersistence()
        {
            MarketValues = new MarketValuesRepository();
        }

        public IMarketValueRepository MarketValues { get; }
    }
}
