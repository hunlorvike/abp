using Layered.BookStore.Localization;

using Microsoft.Extensions.Localization;

using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Layered.BookStore.Web;

[Dependency(ReplaceServices = true)]
public class BookStoreBrandingProvider(IStringLocalizer<BookStoreResource> localizer) : DefaultBrandingProvider
{
    private readonly IStringLocalizer<BookStoreResource> _localizer = localizer;

    public override string AppName => _localizer["AppName"];
}
