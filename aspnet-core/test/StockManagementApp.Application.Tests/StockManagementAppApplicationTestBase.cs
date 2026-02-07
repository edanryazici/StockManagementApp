using Volo.Abp.Modularity;

namespace StockManagementApp;

public abstract class StockManagementAppApplicationTestBase<TStartupModule> : StockManagementAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
