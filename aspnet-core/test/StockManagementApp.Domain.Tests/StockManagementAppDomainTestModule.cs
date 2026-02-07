using Volo.Abp.Modularity;

namespace StockManagementApp;

[DependsOn(
    typeof(StockManagementAppDomainModule),
    typeof(StockManagementAppTestBaseModule)
)]
public class StockManagementAppDomainTestModule : AbpModule
{

}
