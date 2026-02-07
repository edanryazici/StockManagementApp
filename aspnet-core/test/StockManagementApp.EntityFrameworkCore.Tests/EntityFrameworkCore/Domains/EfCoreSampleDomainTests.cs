using StockManagementApp.Samples;
using Xunit;

namespace StockManagementApp.EntityFrameworkCore.Domains;

[Collection(StockManagementAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StockManagementAppEntityFrameworkCoreTestModule>
{

}
