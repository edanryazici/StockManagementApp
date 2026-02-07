using Xunit;

namespace StockManagementApp.EntityFrameworkCore;

[CollectionDefinition(StockManagementAppTestConsts.CollectionDefinitionName)]
public class StockManagementAppEntityFrameworkCoreCollection : ICollectionFixture<StockManagementAppEntityFrameworkCoreFixture>
{

}
