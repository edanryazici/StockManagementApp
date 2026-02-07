using StockManagementApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace StockManagementApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StockManagementAppController : AbpControllerBase
{
    protected StockManagementAppController()
    {
        LocalizationResource = typeof(StockManagementAppResource);
    }
}
