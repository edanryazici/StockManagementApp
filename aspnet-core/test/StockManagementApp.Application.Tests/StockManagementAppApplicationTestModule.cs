using Volo.Abp.Modularity;

namespace StockManagementApp;

[DependsOn(
    typeof(StockManagementAppApplicationModule),
    typeof(StockManagementAppDomainTestModule)
)]
public class StockManagementAppApplicationTestModule : AbpModule
{

}
