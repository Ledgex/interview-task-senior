using System;

namespace Sample.App.Common
{
    public class TenantPersistenceOptions
    {
        public TenantPersistenceOptions(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }
    }
}
