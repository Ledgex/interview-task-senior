namespace Sample.App.Common.DataAccess
{
    public interface ITenantPersistence
    {
        IMarketValueRepository MarketValues { get; }
    }
}
