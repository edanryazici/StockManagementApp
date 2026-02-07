using Microsoft.Extensions.Localization;
using StockManagementApp.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace StockManagementApp;

[Dependency(ReplaceServices = true)]
public class StockManagementAppBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<StockManagementAppResource> _localizer;

    public StockManagementAppBrandingProvider(IStringLocalizer<StockManagementAppResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
