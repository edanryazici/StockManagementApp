using StockManagementApp.Samples;
using Xunit;

namespace StockManagementApp.EntityFrameworkCore.Applications;

[Collection(StockManagementAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StockManagementAppEntityFrameworkCoreTestModule>
{

}
