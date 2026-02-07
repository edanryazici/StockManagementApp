using System;
using System.Collections.Generic;
using System.Text;
using StockManagementApp.Localization;
using Volo.Abp.Application.Services;

namespace StockManagementApp;

/* Inherit your application services from this class.
 */
public abstract class StockManagementAppAppService : ApplicationService
{
    protected StockManagementAppAppService()
    {
        LocalizationResource = typeof(StockManagementAppResource);
    }
}
