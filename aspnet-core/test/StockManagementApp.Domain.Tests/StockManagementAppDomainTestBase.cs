using Volo.Abp.Modularity;

namespace StockManagementApp;

/* Inherit from this class for your domain layer tests. */
public abstract class StockManagementAppDomainTestBase<TStartupModule> : StockManagementAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
