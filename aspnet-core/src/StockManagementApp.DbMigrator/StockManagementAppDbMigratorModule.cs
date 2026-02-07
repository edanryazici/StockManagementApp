using StockManagementApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace StockManagementApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StockManagementAppEntityFrameworkCoreModule),
    typeof(StockManagementAppApplicationContractsModule)
    )]
public class StockManagementAppDbMigratorModule : AbpModule
{
}
